using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace KeyGeneratorApp
{
    public partial class licenceKeyGeneratorUI : Form
    {
        public licenceKeyGeneratorUI()
        {
            InitializeComponent();
        }

        private void licenceKeyGeneratorUI_Load(object sender, EventArgs e)
        {
            passwordTextBox.Select();
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;
            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }
            this.Text = tmp + this.Text.Trim();
            nbLabel.Text = "N.B: Ensure that today's DATE(" + DateTime.Now.ToString("dd-MM-yyyy")+ ") on this computer is set correctly.";

            groupBox.Enabled = false;
            changeButton.Enabled = false;
           // keyboardpictureBox.Visible = true;
        }


        private void licenceKeyGeneratorUI_Resize(object sender, EventArgs e)
        {
            
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;
            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }
            this.Text = tmp + this.Text.Trim();
            
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            Process.Start("timedate.cpl");
        }

        private void accountNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            long num;
            bool isNum = long.TryParse(accountNumberTextBox.Text, out num);

            if ((!isNum || num <= 0) && accountNumberTextBox.Text != "      Empty    " && accountNumberTextBox.TextLength > 0)
            {
                digitCheckLabel.Visible = true;
                this.Update();
                Thread.Sleep(50);
                digitCheckLabel.Visible = false;
                accountNumberTextBox.Text = string.Empty;
                maxAccountNumberLabel.Visible = true;
                maxAccountNumberLabel.Text = "Invalid copied number.Positive numbers only.";
            }

        }

        private void accountNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            int cursorPosition = accountNumberTextBox.SelectionStart;
           
            
               if (cursorPosition == 0 && e.KeyChar == '0')
                {
                    e.Handled = true;
                    maxAccountNumberLabel.Visible = true;
                    maxAccountNumberLabel.Text = "Invalid input.[1st digit can't be Zero(0)]";
                    digitCheckLabel.Visible = true;
                    this.Update();
                    Thread.Sleep(50);
                    digitCheckLabel.Visible = false;
                }
                else if ((accountNumberTextBox.TextLength < 12 && char.IsDigit(e.KeyChar)) || (accountNumberTextBox.SelectionLength >0 && char.IsDigit(e.KeyChar)) || char.IsControl(e.KeyChar))
                {
                    
                    maxAccountNumberLabel.Visible = false;
                }
                else if (accountNumberTextBox.TextLength > 11 && char.IsDigit(e.KeyChar) && accountNumberTextBox.SelectionLength<1)
                {
                    e.Handled = true;
                    maxAccountNumberLabel.Visible = true;
                    maxAccountNumberLabel.Text = "Max: 999999999999 [12 digits]";
                    digitCheckLabel.Visible = true;
                    this.Update();
                    Thread.Sleep(50);
                    digitCheckLabel.Visible = false;
                }
                else if(accountNumberTextBox.SelectionLength<1)
                {
                    e.Handled = true;
                    maxAccountNumberLabel.Visible = true;
                    maxAccountNumberLabel.Text = "Invalid input.[Not Number]";
                    digitCheckLabel.Visible = true;
                    this.Update();
                    Thread.Sleep(50);
                    digitCheckLabel.Visible = false;
                }
                else
                {
                    e.Handled = true;
                    maxAccountNumberLabel.Visible = true;
                    maxAccountNumberLabel.Text = "Invalid input.[Not Number]";
                    digitCheckLabel.Visible = true;
                    this.Update();
                    Thread.Sleep(50);
                    digitCheckLabel.Visible = false;
                }
               if (e.KeyChar == (char)Keys.Enter)
               {
                   generateLicenceKeyButton_Click(sender, e);

               }
        }

        private int maxDays;
        private void validityTextBox_TextChanged(object sender, EventArgs e)
        {
            long num;
            bool isNum = long.TryParse(validityTextBox.Text, out num);
            if ((!isNum || num <= 0) && validityTextBox.Text != "  Empty    " && validityTextBox.TextLength > 0)
            {
                digitCheckDaysLabel.Visible = true;
                this.Update();
                Thread.Sleep(50);
                digitCheckDaysLabel.Visible = false;
                validityTextBox.Text = string.Empty;
                maxValidDaysLabel.Visible = true;
                maxValidDaysLabel.Text = "Invalid copied number.";
            }
            try
            {
                DateTime tillDate = DateTime.Now.AddDays(Convert.ToInt32(validityTextBox.Text));
                validTillabel.Text = tillDate.ToString("dd-MM-yyyy");
                DateTime heightDate = DateTime.Parse("31-12-2026");
                TimeSpan maxValidity = heightDate.Date - DateTime.Now.Date;
                maxDays = Convert.ToInt32(maxValidity.TotalDays);
                if (tillDate.Date > heightDate.Date)
                {
                    maxValidDaysLabel.Visible = true;
                    maxValidDaysLabel.Text = "Max: "+maxDays.ToString();
                    validityTextBox.Text = validityTextBox.Text.Remove(validityTextBox.TextLength - 1); //or validityTextBox.Text = validityTextBox.Text.Substring(0, (validityTextBox.TextLength - 1));
                    validityTextBox.Select(validityTextBox.TextLength,0);  //or validityTextBox.SelectionStart = validityTextBox.Text.Length;
                    digitCheckDaysLabel.Visible = true;
                    this.Update();
                    Thread.Sleep(50);
                    digitCheckDaysLabel.Visible = false;
                }

            }
            catch (Exception)
            {
                validTillabel.Text = "dd-mm-yyyy";
            }

        }

        private void validityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            int cursorPosition = validityTextBox.SelectionStart;
            if (cursorPosition == 0 && e.KeyChar == '0')
            {
                e.Handled = true;
                maxValidDaysLabel.Visible = true;
                maxValidDaysLabel.Text = "Invalid input.[1st digit can't be Zero(0)]";
                digitCheckDaysLabel.Visible = true;
                this.Update();
                Thread.Sleep(50);
                digitCheckDaysLabel.Visible = false;
            }
            else if ((validityTextBox.TextLength < 4 && char.IsDigit(e.KeyChar)) || (validityTextBox.SelectionLength > 0 && char.IsDigit(e.KeyChar)) || char.IsControl(e.KeyChar))
            {
                maxValidDaysLabel.Visible = false;
            }
            else if (validityTextBox.TextLength > 3 && char.IsDigit(e.KeyChar) && validityTextBox.SelectionLength < 1)
            {
                e.Handled = true;
                maxValidDaysLabel.Visible = true;
                maxValidDaysLabel.Text = "Max: " + maxDays.ToString();
                digitCheckDaysLabel.Visible = true;
                this.Update();
                Thread.Sleep(50);
                digitCheckDaysLabel.Visible = false;
            }
            else if (validityTextBox.SelectionLength < 1)
            {
                e.Handled = true;
                maxValidDaysLabel.Visible = true;
                maxValidDaysLabel.Text = "Invalid input.[Not Number]";
                digitCheckDaysLabel.Visible = true;
                this.Update();
                Thread.Sleep(50);
                digitCheckDaysLabel.Visible = false;
            }
            else
            {
                e.Handled = true;
                maxValidDaysLabel.Visible = true;
                maxValidDaysLabel.Text = "Invalid input.[Not Number]";
                digitCheckDaysLabel.Visible = true;
                this.Update();
                Thread.Sleep(50);
                digitCheckDaysLabel.Visible = false;
            }
            

        }

        private void validityTextBox_Click(object sender, EventArgs e)
        {
            string strInput = accountNumberTextBox.Text.TrimStart('0');
            accountNumberTextBox.Text = strInput;
            maxAccountNumberLabel.Visible = false;
        }

        private void accountNumberCopyButton_Click(object sender, EventArgs e)
        {
            maxAccountNumberLabel.Visible = false;
            try
            {
                Clipboard.SetText(accountNumberTextBox.Text);
                accountNumberCopyButton.Text = "Copied";
                accountNumberCopyButton.BackColor = Color.Lime;
                accountNumberCopyButton.ForeColor = Color.Black;
                this.Update();
                Thread.Sleep(100);
                accountNumberCopyButton.Text = "Copy";
                accountNumberCopyButton.BackColor = Color.RoyalBlue;
                accountNumberCopyButton.ForeColor = Color.White;
            }
            catch (Exception)
            {
                
                accountNumberTextBox.Text = "      Empty    ";
                accountNumberTextBox.BackColor = Color.Salmon;
                accountNumberCopyButton.Text = "Fail";
                accountNumberCopyButton.BackColor = Color.Red;
                accountNumberCopyButton.ForeColor = Color.Black;
                this.Update();
                Thread.Sleep(100);
                accountNumberTextBox.Text = string.Empty;
                accountNumberTextBox.BackColor = Color.White;
                accountNumberCopyButton.Text = "Copy";
                accountNumberCopyButton.BackColor = Color.RoyalBlue;
                accountNumberCopyButton.ForeColor = Color.White;
            }
            
            
        }

        private void validDateCopyButton_Click(object sender, EventArgs e)
        {
            maxValidDaysLabel.Visible = false;
            if (!(validityTextBox.Text == ""))
            {
                Clipboard.SetText(validTillabel.Text);
                validDateCopyButton.Text = "Copied";
                validDateCopyButton.BackColor = Color.Lime;
                validDateCopyButton.ForeColor = Color.Black;
                this.Update();
                Thread.Sleep(100);
                validDateCopyButton.Text = "Copy";
                validDateCopyButton.BackColor = Color.RoyalBlue;
                validDateCopyButton.ForeColor = Color.White;
            }
            else
            {
                
                validityTextBox.Text = "  Empty    ";
                validTillabel.Text = "No Date";
                validityTextBox.BackColor = Color.Salmon;
                validDateCopyButton.Text = "Fail";
                validDateCopyButton.BackColor = Color.Red;
                validDateCopyButton.ForeColor = Color.Black;
                this.Update();
                Thread.Sleep(50);
                validityTextBox.Text = string.Empty;
                validTillabel.Text = "dd-mm-yyyy";
                validityTextBox.BackColor = Color.White;
                validDateCopyButton.Text = "Copy";
                validDateCopyButton.BackColor = Color.RoyalBlue;
                validDateCopyButton.ForeColor = Color.White;
            }
            
        }

        private void licenceKeyCopyButton_Click(object sender, EventArgs e)
        {
            if (!(validityTextBox.Text == ""))
            {
                Clipboard.SetText(licenceKeyTextBox.Text);
                licenceKeyCopyButton.Text = "Copied";
                licenceKeyCopyButton.BackColor = Color.Lime;
                licenceKeyCopyButton.ForeColor = Color.Black;
                this.Update();
                Thread.Sleep(100);
                licenceKeyCopyButton.Text = "Copy";
                licenceKeyCopyButton.BackColor = Color.RoyalBlue;
                licenceKeyCopyButton.ForeColor = Color.White;
            }
            else
            {
                maxValidDaysLabel.Visible = false;
                licenceKeyTextBox.Text = "  Empty    ";
                licenceKeyTextBox.BackColor = Color.Salmon;
                licenceKeyCopyButton.Text = "Fail";
                licenceKeyCopyButton.BackColor = Color.Red;
                licenceKeyCopyButton.ForeColor = Color.Black;
                this.Update();
                Thread.Sleep(100);
                licenceKeyTextBox.Text = string.Empty;
                licenceKeyTextBox.BackColor = Color.White;
                licenceKeyCopyButton.Text = "Copy";
                licenceKeyCopyButton.BackColor = Color.RoyalBlue;
                licenceKeyCopyButton.ForeColor = Color.White;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string myString = "path is a zero-length string, contains only white space, or contains one or more invalid characters.";
            try
            {
                string rootDrive = Path.GetPathRoot(Environment.SystemDirectory);
                StreamReader myFile = new StreamReader(rootDrive + "\\Windows\\System32\\lkgp.txt");
                myString = myFile.ReadToEnd();
                myFile.Close();
            }
            catch (Exception)
            {

                ;
            }
            
            if (loginButton.Text == "Log In")
            {
                if (passwordTextBox.Text == myString)
                {
                    groupBox.Enabled = true;
                    passwordTextBox.Text = string.Empty;
                    passwordTextBox.Enabled = false;
                    loginButton.Text = "Log Out";
                    changeButton.Enabled = true;
                    loginButton.BackColor = Color.Transparent;

                }

                else
                {
                    passwordTextBox.Select();
                    passwordTextBox.UseSystemPasswordChar = false;
                    passwordTextBox.TextAlign = HorizontalAlignment.Center;
                    passwordTextBox.Text = "Wrong Password";
                    passwordTextBox.ForeColor = Color.Red;
                }
            
            }
            else
            {
                loginButton.Text = "Log In";
                groupBox.Enabled = false;
                passwordTextBox.Enabled = true;
                changeButton.Enabled = false;
                maxAccountNumberLabel.Visible = false;
                maxValidDaysLabel.Visible = false;
                accountNumberTextBox.Text = string.Empty;
                validityTextBox.Text = string.Empty;
                validTillabel.Text = "dd-mm-yyyy";
                licenceKeyTextBox.Text = string.Empty;
                loginButton_MouseLeave(sender,e);
            }
            accountNumberTextBox.Select();
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            passwordTextBox.Text = string.Empty;
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.TextAlign = HorizontalAlignment.Left;
            
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (passwordTextBox.Text == "Wrong Password")
            {
                passwordTextBox_Click(sender,e);
                passwordTextBox.Text = e.KeyChar.ToString();
                passwordTextBox.Select(passwordTextBox.TextLength, 0);
                

            }
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginButton_Click(sender, e);
               
            }
        }

        private void copyAllButton_Click(object sender, EventArgs e)
        {
            maxAccountNumberLabel.Visible = false;
            maxValidDaysLabel.Visible = false;
            if (accountNumberTextBox.Text == "")
            {
                
                accountNumberTextBox.Text = "      Empty    ";
                accountNumberTextBox.BackColor = Color.Salmon;
                copyAllButton.Text = "Fail";
                copyAllButton.BackColor = Color.Red;
                copyAllButton.ForeColor = Color.Black;
                this.Update();
                Thread.Sleep(100);
                accountNumberTextBox.Text = string.Empty;
                accountNumberTextBox.BackColor = Color.White;
                copyAllButton.Text = "Copy All";
                copyAllButton.BackColor = Color.LightSeaGreen;
                copyAllButton.ForeColor = Color.White;
                
               
            }
            else if(validityTextBox.Text == "")
            {
                
                validityTextBox.Text = "  Empty    ";
                validTillabel.Text = "No Date";
                validityTextBox.BackColor = Color.Salmon;
                copyAllButton.Text = "Fail";
                copyAllButton.BackColor = Color.Red;
                copyAllButton.ForeColor = Color.Black;
                this.Update();
                Thread.Sleep(50);
                validityTextBox.Text = string.Empty;
                validTillabel.Text = "dd-mm-yyyy";
                validityTextBox.BackColor = Color.White;
                copyAllButton.Text = "Copy All";
                copyAllButton.BackColor = Color.LightSeaGreen;
                copyAllButton.ForeColor = Color.White;
            }
            else if (licenceKeyTextBox.Text == "")
            {
                licenceKeyTextBox.Text = "  Empty    ";
                licenceKeyTextBox.BackColor = Color.Salmon;
                copyAllButton.Text = "Fail";
                copyAllButton.BackColor = Color.Red;
                copyAllButton.ForeColor = Color.Black;
                this.Update();
                Thread.Sleep(50);
                licenceKeyTextBox.Text = string.Empty;
                licenceKeyTextBox.BackColor = Color.White;
                copyAllButton.Text = "Copy All";
                copyAllButton.BackColor = Color.LightSeaGreen;
                copyAllButton.ForeColor = Color.White;
            }
            else
            {
                DateTime td = DateTime.Now;
                string tdate = td.ToString("dd-MM-yyyy");
                string myText = @"---------------- " + tdate + @" ----------------------
            Account Number: " + accountNumberTextBox.Text + @"
               Licence key: " + licenceKeyTextBox.Text + @"
                  Validity: " + validTillabel.Text + @"
--------------------------------------------------

";
                Clipboard.SetText(myText);
                copyAllButton.Text = "Copied";
                copyAllButton.BackColor = Color.Lime;
                copyAllButton.ForeColor = Color.Black;
                this.Update();
                Thread.Sleep(100);
                copyAllButton.Text = "Copy All";
                copyAllButton.BackColor = Color.LightSeaGreen;
                copyAllButton.ForeColor = Color.White;
            }
            
        }

        private void generateLicenceKeyButton_Click(object sender, EventArgs e)
        {
            maxAccountNumberLabel.Visible = false;
            maxValidDaysLabel.Visible = false;
            if (accountNumberTextBox.Text == "")
            {
                
                accountNumberTextBox.Text = "      Empty    ";
                accountNumberTextBox.BackColor = Color.Salmon;
                generateLicenceKeyButton.Text = "Fail";
                generateLicenceKeyButton.BackColor = Color.Red;
                this.Update();
                Thread.Sleep(100);
                accountNumberTextBox.Text = string.Empty;
                accountNumberTextBox.BackColor = Color.White;
                generateLicenceKeyButton.Text = "Generate Licence Key";
                generateLicenceKeyButton.BackColor = Color.DarkKhaki;
                


            }
            else if (validityTextBox.Text == "")
            {

                validityTextBox.Text = "  Empty    ";
                validityTextBox.BackColor = Color.Salmon;
                generateLicenceKeyButton.Text = "Fail";
                generateLicenceKeyButton.BackColor = Color.Red;
                this.Update();
                Thread.Sleep(100);
                validityTextBox.Text = string.Empty;
                validityTextBox.BackColor = Color.White;
                generateLicenceKeyButton.Text = "Generate Licence Key";
                generateLicenceKeyButton.BackColor = Color.DarkKhaki;
            }
            else
            {
                try
                {
                    generateLicenceKeyButton.BackColor = Color.LightGreen;
                    DateTime dd = DateTime.Now.AddDays(Convert.ToInt32(validityTextBox.Text));
                    int validDays = ((dd.Year - 2014) * 365 + dd.Month * 30 + dd.Day) * 2;
                    long accountNumber = Convert.ToInt64(accountNumberTextBox.Text);
                    int t = validDays, r;
                    long validLicenceKey = 0;
                    while (t > 0)
                    {
                        r = t % 10;
                        validLicenceKey += r;
                        t = t / 10;
                    }
                    validLicenceKey = (long)((36 - validLicenceKey) * 10204710603 + accountNumber * 3 + Math.Pow(validLicenceKey, 7) + validDays * 5937142 + Math.Pow(2.1932, (36 - validLicenceKey)) * 1.6209 + Math.Log(validDays + validLicenceKey + accountNumber) * 100316046);
                    if (validLicenceKey < 100000000000) validLicenceKey += 100000000000;
                    else if (validLicenceKey >= 1000000000000) validLicenceKey /= 10;

                    validLicenceKey = ((validLicenceKey / 100000000) * 10000 + validDays) * 100000000 + validLicenceKey % 100000000;

                    string vk = validLicenceKey.ToString();
                    string sb = vk.Substring(0, 4) + "-" + vk.Substring(4, 4) + "-" + vk.Substring(8, 4) + "-" + vk.Substring(12, 4);

                    // int yyyy = ((DateTime.Now.Year-2014)*365+DateTime.Now.Month*30+DateTime.Now.Day)*2+Convert.ToInt32(validityTextBox.Text)*2;
                    //licenceKeyTextBox.Text = dd.ToString("dd/MM/yyyy");
                    licenceKeyTextBox.Text = sb;
                    //long accountNumber = Convert.ToInt64(accountNumberTextBox.Text);
                    this.Update();
                    Thread.Sleep(100);
                    generateLicenceKeyButton.BackColor = Color.DarkKhaki;

                    if (saveCheckBox.Checked)
                    {
                        DateTime td = DateTime.Now;
                        string tdate = td.ToString("dd-MM-yyyy");
                        string myText = @"---------------- " + tdate + @" ----------------------
            Account Number: " + accountNumberTextBox.Text + @"
               Licence key: " + licenceKeyTextBox.Text + @"
                  Validity: " + validTillabel.Text + @"
--------------------------------------------------

";
                        Clipboard.SetText(myText);
                        string datetoday = DateTime.Now.ToString("dd-MM-yyyy");
                        string fileName = datetoday + ".txt";
                        string dir = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents", "Licence_Key_Generator", fileName);
                        File.AppendAllText(dir, Clipboard.GetText());
                    }
                    

                }
                catch (Exception)
                {
                    
                    licenceKeyTextBox.Text="Critical Error.";
                }
                
            }
            

        }

        private void validityTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                generateLicenceKeyButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                try
                {
                    int a = 0;
                    if (!(validityTextBox.Text == ""))
                        a = Convert.ToInt32(validityTextBox.Text);
                    a++;
                    validityTextBox.Text = a.ToString(); 
                }
                catch (Exception)
                {

                    ;
                }
                
            }
            else if (e.KeyCode == Keys.Down)
            {
                try
                {
                    int a = Convert.ToInt32(validityTextBox.Text);
                    a--;
                   if(a>0) validityTextBox.Text = a.ToString();
                }
                catch (Exception)
                {

                    validityTextBox.Text = "  Empty    ";
                    validityTextBox.BackColor = Color.Salmon;
                    this.Update();
                    Thread.Sleep(50);
                    validityTextBox.Text = string.Empty;
                    validityTextBox.BackColor = Color.White;
                    
                }
                
            }
        }
        private void validityTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) validityTextBox.Select(validityTextBox.TextLength, 0);
        }

        private void accountNumberTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                generateLicenceKeyButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                try
                {
                    long a = 0;
                    if (!(accountNumberTextBox.Text == ""))
                        a = Convert.ToInt64(accountNumberTextBox.Text);
                    a++;
                    accountNumberTextBox.Text = a.ToString();
                }
                catch (Exception)
                {

                    ;
                }

            }
            else if (e.KeyCode == Keys.Down)
            {
                try
                {
                    long a = Convert.ToInt64(accountNumberTextBox.Text);
                    a--;
                    if (a > 0) accountNumberTextBox.Text = a.ToString();
                }
                catch (Exception)
                {

                    accountNumberTextBox.Text = "      Empty    ";
                    accountNumberTextBox.BackColor = Color.Salmon;
                    this.Update();
                    Thread.Sleep(50);
                    accountNumberTextBox.Text = string.Empty;
                    accountNumberTextBox.BackColor = Color.White;

                }

            }


        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
                loginButton.BackColor = Color.Blue;
                this.Update();
                Thread.Sleep(50);
                if(loginButton.Text=="Log Out")
                loginButton.BackColor = Color.Transparent;
                else
                {
                    loginButton.BackColor = Color.DeepSkyBlue;   
                }
            }
        }

        private void loginButton_MouseHover(object sender, EventArgs e)
        {
            if(loginButton.Text=="Log In")
            loginButton.BackColor = Color.Blue;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            if (loginButton.Text == "Log In")
            loginButton.BackColor = Color.DeepSkyBlue;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            accountNumberTextBox.Text = string.Empty;
            validityTextBox.Text = string.Empty;
            licenceKeyTextBox.Text = string.Empty;
            accountNumberTextBox.Select();
        }

        private void saveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (saveCheckBox.Checked)
            {
                openButton.Visible = true;
               // File.Create(@"C:\Users\A1\Documents\Yourfile.txt");
                string dir = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents","Licence_Key_Generator");
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                string datetoday = DateTime.Now.ToString("dd-MM-yyyy");
                string fileName = datetoday + ".txt";
                dir = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents", "Licence_Key_Generator", fileName);
                if (!File.Exists(dir))
                {
                    File.Create(dir).Close();
                }
            }
            else
            {
                openButton.Visible = false;
            }
        }
        private Process openApplication = null;
        private void openButton_Click(object sender, EventArgs e)
        {
            string dir = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "Documents", "Licence_Key_Generator");
            if (openApplication == null)
            {
                try
                {
                    openApplication = Process.Start(dir);

                }
                catch (Exception)
                {

                    MessageBox.Show("No 'Licence_Key_Generator' folder found.");
                }
            }
            else if (openApplication != null)
            {
                try
                {
                    openApplication.Kill();
                    openApplication = Process.Start(dir);

                }
                catch (Exception)
                {
                    try
                    {
                        openApplication = Process.Start(dir);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("No 'Licence_Key_Generator' folder found.");
                    }

                    
                }

            }
        }

        private void keyboardpictureBox_Click(object sender, EventArgs e)
        {
            Process.Start("osk.exe");
        }

        private void accountNumberTextBox_Click(object sender, EventArgs e)
        {
            string strInput = validityTextBox.Text.TrimStart('0');
            validityTextBox.Text = strInput;
            maxValidDaysLabel.Visible = false;
        }

        private void accountNumberTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) accountNumberTextBox.Select(accountNumberTextBox.TextLength, 0);

        }

        


    }
}
