using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace RegisterComObject
{
    public partial class MainForm : Form
    {
        private string _lastOperationType = "";
        private bool _isLastOperationSuccess;

        private readonly List<string> _regasmPaths = new List<string>
        {
            @"C:\Windows\Microsoft.NET\Framework64\v2.0.50727\regasm.exe",
            @"C:\Windows\Microsoft.NET\Framework64\v4.0.30319\regasm.exe",
            @"C:\Windows\Microsoft.NET\Framework\v2.0.50727\regasm.exe",
            @"C:\Windows\Microsoft.NET\Framework\v4.0.30319\regasm.exe"
        };


        public MainForm()
        {
            InitializeComponent();
        }

        private void btnUnregister_Click(object sender, EventArgs e)
        {
            if (!HasValidRegasmFilePath())
            {
                MessageBox.Show("Invalid regasm.exe file path! Check regasm.exe file exists in the specified location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            _lastOperationType = "unregister";
            RunRegAsmCommand($"/u \"{txtDllPath.Text}\"");

            if (File.Exists(GetTlbFilePath()))
            {
                File.Delete(GetTlbFilePath());
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDllPath.Text = openFileDialog1.FileName;
            }
        }

        private void txtDllPath_TextChanged(object sender, EventArgs e)
        {
            txtDllPath.Text = txtDllPath.Text.Trim();
            var hasDllFilePath = txtDllPath.Text.EndsWith("dll", StringComparison.InvariantCultureIgnoreCase) && File.Exists(txtDllPath.Text);

            btnUnregister.Enabled = hasDllFilePath;
            btnRegister.Enabled = hasDllFilePath;

            if (hasDllFilePath)
            {
                PrintDllInfo();
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!HasValidRegasmFilePath())
            {
                MessageBox.Show("Invalid regasm.exe file path! Check regasm.exe file exists in the specified location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            _lastOperationType = "register";
            var tlbPath = GetTlbFilePath();
            var regasmArguments = $"/codebase /tlb:\"{tlbPath}\" \"{txtDllPath.Text}\"";
            RunRegAsmCommand(regasmArguments);
        }

        private bool HasValidRegasmFilePath()
        {
            return File.Exists(txtRegasmPath.Text) && new FileInfo(txtRegasmPath.Text).Name.ToLower() == "regasm.exe";
        }

        private string GetTlbFilePath()
        {
            var dllPath = new FileInfo(txtDllPath.Text);
            return Path.Combine(dllPath.Directory.FullName, Path.GetFileNameWithoutExtension(txtDllPath.Text)) + ".tlb";
        }

        private void RunRegAsmCommand(string regasmArguments)
        {

            try
            {
                txtLog.Text = "";
                _isLastOperationSuccess = false;
                txtLog.BackColor = Color.LightGoldenrodYellow;


                var process = new Process();
                var processStartInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Normal,
                    FileName = txtRegasmPath.Text,
                    Arguments = regasmArguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    Verb = "runas"
                };

                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;


                process.StartInfo = processStartInfo;
                process.OutputDataReceived += Process_OutputDataReceived;

                process.Start();
                process.BeginOutputReadLine();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }






        //private void ShowRegistrationResult()
        //{
        //    if (_isLastOperationSuccess)
        //    {
        //        MessageBox.Show("Successfully completed :)", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Problem occured :(", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}


        private void Process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                txtLog.Text += e.Data + Environment.NewLine;

                if (e.Data != null)
                {
                    if (_lastOperationType == "register")
                    {
                        if (e.Data.Contains("registered successfully"))
                        {
                            _isLastOperationSuccess = true;
                            txtLog.BackColor = Color.Honeydew;
                        }
                    }
                    else if (_lastOperationType == "unregister")
                    {
                        if (e.Data.Contains("un-registered successfully"))
                        {
                            _isLastOperationSuccess = true;
                            txtLog.BackColor = Color.Honeydew;
                        }
                    }
                }


            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            DetectRegasmFileLocation();
        }

        private void DetectRegasmFileLocation()
        {
            _regasmPaths.ForEach(regasmPath =>
            {
                if (File.Exists(regasmPath))
                {
                    txtRegasmPath.Text = regasmPath;
                }
            });
        }

        private void txtRegasmPath_TextChanged(object sender, EventArgs e)
        {
            txtRegasmPath.Text = txtRegasmPath.Text.Trim();
            if (HasValidRegasmFilePath())
            {
                lblPlatform.Text = txtRegasmPath.Text.Contains(@"Framework64\") ? "64 Bit" : "32 Bit";
                lblInvalidRegasmPath.Visible = false;
            }
            else
            {
                lblPlatform.Text = "";
                lblInvalidRegasmPath.Visible = true;
            }
        }

        private void PrintDllInfo()
        {
            try
            {
                txtDllInfo.Text = "";
                var assembly = Assembly.LoadFile(txtDllPath.Text);
                var allPublicClasses = GetLoadableTypes(assembly);

                foreach (var type in allPublicClasses)
                {
                    var methods = GetMethods(type);
                    if (methods != null && methods.Count > 0)
                    {
                        AppendFormattedText(txtDllInfo, type.FullName + ":" + Environment.NewLine, Color.Navy, true, HorizontalAlignment.Left);

                        methods.ForEach(m =>
                        {
                            AppendFormattedText(txtDllInfo, m + Environment.NewLine, Color.Black, false, HorizontalAlignment.Left);
                        });

                        AppendFormattedText(txtDllInfo, new string('_', 50) + Environment.NewLine + Environment.NewLine, Color.Green, false, HorizontalAlignment.Left);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        List<string> GetMethods(Type type)
        {
            List<string> methods = new List<string>();

            foreach (var method in type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly))
            {
                var parameters = method.GetParameters();
                string parameterDescriptions = "";
                foreach (var parameter in parameters)
                {
                    parameterDescriptions += parameter.ParameterType + " " + parameter.Name + ", ";
                }

                methods.Add($"{method.ReturnType} {method.Name} ({parameterDescriptions.TrimEnd(' ').TrimEnd(',')})");
            }

            return methods;
        }




        public static IEnumerable<Type> GetLoadableTypes(Assembly assembly)
        {

            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                var types = new List<Type>();
                foreach (var eType in e.Types)
                {
                    if (eType != null && eType.IsPublic)
                    {
                        types.Add(eType);
                    }
                }

                return types;
            }
        }


        private void AppendFormattedText(RichTextBox rtb, string text, Color textColour, Boolean isBold, HorizontalAlignment alignment)
        {
            int start = rtb.TextLength;
            rtb.AppendText(text);
            int end = rtb.TextLength; // now longer by length of appended text

            // Select text that was appended
            rtb.Select(start, end - start);

            #region Apply Formatting
            rtb.SelectionColor = textColour;
            rtb.SelectionAlignment = alignment;
            rtb.SelectionFont = new Font(
                 rtb.SelectionFont.FontFamily,
                 rtb.SelectionFont.Size,
                 (isBold ? FontStyle.Bold : FontStyle.Regular));
            #endregion

            // Unselect text
            rtb.SelectionLength = 0;
        }

    }
}
