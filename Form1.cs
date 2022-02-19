using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using ConnectFour.Properties;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ConnectFour
{
    public partial class Form1 : Form
    {

        public Dictionary<string, string> coinList = new();
        public static List<string> yellowCoinList = new();
        public static List<string> redCoinList = new();
        public static TaskDialogPage tdp = new()
        {
            Text = "",
            Heading = "",
            Caption = "Winner",
            Buttons =
            {
                TaskDialogButton.OK
            },
            Icon = TaskDialogIcon.Information,
            DefaultButton = TaskDialogButton.OK
        };

        public Form1()
        {
            InitializeComponent();

            coinList.Add("X1Y1", "Blank");
            coinList.Add("X1Y2", "Blank");
            coinList.Add("X1Y3", "Blank");
            coinList.Add("X1Y4", "Blank");
            coinList.Add("X1Y5", "Blank");

            coinList.Add("X2Y1", "Blank");
            coinList.Add("X2Y2", "Blank");
            coinList.Add("X2Y3", "Blank");
            coinList.Add("X2Y4", "Blank");
            coinList.Add("X2Y5", "Blank");

            coinList.Add("X3Y1", "Blank");
            coinList.Add("X3Y2", "Blank");
            coinList.Add("X3Y3", "Blank");
            coinList.Add("X3Y4", "Blank");
            coinList.Add("X3Y5", "Blank");

            coinList.Add("X4Y1", "Blank");
            coinList.Add("X4Y2", "Blank");
            coinList.Add("X4Y3", "Blank");
            coinList.Add("X4Y4", "Blank");
            coinList.Add("X4Y5", "Blank");

            coinList.Add("X5Y1", "Blank");
            coinList.Add("X5Y2", "Blank");
            coinList.Add("X5Y3", "Blank");
            coinList.Add("X5Y4", "Blank");
            coinList.Add("X5Y5", "Blank");

            TaskDialogButton redButton = new("Red");
            TaskDialogButton yellowButton = new("Yellow");

            TaskDialogButton result = TaskDialog.ShowDialog(this, new TaskDialogPage()
            {
                Text = "Who should go first?",
                Buttons =
                {
                    redButton,
                    yellowButton
                },
                Icon = TaskDialogIcon.Information,
                Caption = "Connect Four"
            });

            if (result == redButton)
            {
                CurrentUser = "Red";
            }
            else if (result == yellowButton)
            {
                CurrentUser = "Yellow";
            }

            CurrentUserLabel.Text = $"{CurrentUser}'s turn";


        }

        public string CurrentUser = "";

        private void ButtonX1_Click(object sender, EventArgs e)
        {

            if (coinList["X1Y1"] != "Blank")
            {
                if (coinList["X1Y2"] != "Blank")
                {
                    if (coinList["X1Y3"] != "Blank")
                    {
                        if (coinList["X1Y4"] != "Blank")
                        {
                            if (coinList["X1Y5"] != "Blank")
                            {
                                
                            }
                            else
                            {
                                X1Y5.Image = GetImage();
                                AddToList("X1Y5");
                                ButtonX1.Enabled = false;
                            }
                        }
                        else
                        {
                            X1Y4.Image = GetImage();
                            AddToList("X1Y4");
                        }
                    }
                    else
                    {
                        X1Y3.Image = GetImage();
                        AddToList("X1Y3");
                    }
                }
                else
                {
                    X1Y2.Image = GetImage();
                    AddToList("X1Y2");
                }
            }
            else
            {
                X1Y1.Image = GetImage();
                AddToList("X1Y1");
            }

            ReverseUser();
        }


        private void AddToList(string coin)
        {
            coinList.Remove(coin);
            coinList.Add(coin, CurrentUser);
            switch (CurrentUser)
            {
                case "Red":
                    redCoinList.Add(coin);
                    break;
                case "Yellow":
                    yellowCoinList.Add(coin);
                    break;
            }

            if (Checks.CheckYellow("vertical"))
            {
                ButtonX1.Enabled = false;
                ButtonX2.Enabled = false;
                ButtonX3.Enabled = false;
                ButtonX4.Enabled = false;
                ButtonX5.Enabled = false;
                CurrentUserLabel.Text = "Yellow won!";
                tdp.Text = "Yellow won!";
                TaskDialog.ShowDialog(this, tdp);
                RestartButton.Visible = true;
            }
            else if (Checks.CheckYellow("horizontal"))
            {
                ButtonX1.Enabled = false;
                ButtonX2.Enabled = false;
                ButtonX3.Enabled = false;
                ButtonX4.Enabled = false;
                ButtonX5.Enabled = false;
                CurrentUserLabel.Text = "Yellow won!";
                tdp.Text = "Yellow won!";
                TaskDialog.ShowDialog(this, tdp);
                RestartButton.Visible = true;
            }
            else if (Checks.CheckYellow("diagonal"))
            {
                ButtonX1.Enabled = false;
                ButtonX2.Enabled = false;
                ButtonX3.Enabled = false;
                ButtonX4.Enabled = false;
                ButtonX5.Enabled = false;
                CurrentUserLabel.Text = "Yellow won!";
                tdp.Text = "Yellow won!";
                TaskDialog.ShowDialog(this, tdp);
                RestartButton.Visible = true;
            }
            else if (Checks.CheckRed("vertical"))
            {
                ButtonX1.Enabled = false;
                ButtonX2.Enabled = false;
                ButtonX3.Enabled = false;
                ButtonX4.Enabled = false;
                ButtonX5.Enabled = false;
                CurrentUserLabel.Text = "Red won!";
                tdp.Text = "Red won!";
                TaskDialog.ShowDialog(this, tdp);
                RestartButton.Visible = true;
            }
            else if (Checks.CheckRed("horizontal"))
            {
                ButtonX1.Enabled = false;
                ButtonX2.Enabled = false;
                ButtonX3.Enabled = false;
                ButtonX4.Enabled = false;
                ButtonX5.Enabled = false;
                CurrentUserLabel.Text = "Red won!";
                tdp.Text = "Red won!";
                TaskDialog.ShowDialog(this, tdp);
                RestartButton.Visible = true;
            }
            else if (Checks.CheckRed("diagonal"))
            {
                ButtonX1.Enabled = false;
                ButtonX2.Enabled = false;
                ButtonX3.Enabled = false;
                ButtonX4.Enabled = false;
                ButtonX5.Enabled = false;
                CurrentUserLabel.Text = "Red won!";
                tdp.Text = "Red won!";
                TaskDialog.ShowDialog(this, tdp);
                RestartButton.Visible = true;
            }
            else if (!coinList.ContainsValue("Blank"))
            {
                ButtonX1.Enabled = false;
                ButtonX2.Enabled = false;
                ButtonX3.Enabled = false;
                ButtonX4.Enabled = false;
                ButtonX5.Enabled = false;
                CurrentUserLabel.Text = "Game ended in a stalemate.";
                tdp.Text = "Stalemate...";
                TaskDialog.ShowDialog(this, tdp);
                RestartButton.Visible = true;
            }
        }

        private void ButtonX2_Click(object sender, EventArgs e)
        {
            if (coinList["X2Y1"] != "Blank")
            {
                if (coinList["X2Y2"] != "Blank")
                {
                    if (coinList["X2Y3"] != "Blank")
                    {
                        if (coinList["X2Y4"] != "Blank")
                        {
                            if (coinList["X2Y5"] != "Blank")
                            {

                            }
                            else
                            {
                                X2Y5.Image = GetImage();
                                AddToList("X2Y5");
                                ButtonX2.Enabled = false;
                            }
                        }
                        else
                        {
                            X2Y4.Image = GetImage();
                            AddToList("X2Y4");
                        }
                    }
                    else
                    {
                        X2Y3.Image = GetImage();
                        AddToList("X2Y3");
                    }
                }
                else
                {
                    X2Y2.Image = GetImage();
                    AddToList("X2Y2");
                }
            }
            else
            {
                X2Y1.Image = GetImage();
                AddToList("X2Y1");
            }

            ReverseUser();
        }

        private void ButtonX3_Click(object sender, EventArgs e)
        {
            if (coinList["X3Y1"] != "Blank")
            {
                if (coinList["X3Y2"] != "Blank")
                {
                    if (coinList["X3Y3"] != "Blank")
                    {
                        if (coinList["X3Y4"] != "Blank")
                        {
                            if (coinList["X3Y5"] != "Blank")
                            {

                            }
                            else
                            {
                                X3Y5.Image = GetImage();
                                AddToList("X3Y5");
                                ButtonX3.Enabled = false;
                            }
                        }
                        else
                        {
                            X3Y4.Image = GetImage();
                            AddToList("X3Y4");
                        }
                    }
                    else
                    {
                        X3Y3.Image = GetImage();
                        AddToList("X3Y3");
                    }
                }
                else
                {
                    X3Y2.Image = GetImage();
                    AddToList("X3Y2");
                }
            }
            else
            {
                X3Y1.Image = GetImage();
                AddToList("X3Y1");
            }
            ReverseUser();
        }

        private void ButtonX4_Click(object sender, EventArgs e)
        {
            if (coinList["X4Y1"] != "Blank")
            {
                if (coinList["X4Y2"] != "Blank")
                {
                    if (coinList["X4Y3"] != "Blank")
                    {
                        if (coinList["X4Y4"] != "Blank")
                        {
                            if (coinList["X4Y5"] != "Blank")
                            {

                            }
                            else
                            {
                                X4Y5.Image = GetImage();
                                AddToList("X4Y5");
                                ButtonX4.Enabled = false;
                            }
                        }
                        else
                        {
                            X4Y4.Image = GetImage();
                            AddToList("X4Y4");
                        }
                    }
                    else
                    {
                        X4Y3.Image = GetImage();
                        AddToList("X4Y3");
                    }
                }
                else
                {
                    X4Y2.Image = GetImage();
                    AddToList("X4Y2");
                }
            }
            else
            {
                X4Y1.Image = GetImage();
                AddToList("X4Y1");
            }
            ReverseUser();
        }

        private void ButtonX5_Click(object sender, EventArgs e)
        {
            if (coinList["X5Y1"] != "Blank")
            {
                if (coinList["X5Y2"] != "Blank")
                {
                    if (coinList["X5Y3"] != "Blank")
                    {
                        if (coinList["X5Y4"] != "Blank")
                        {
                            if (coinList["X5Y5"] != "Blank")
                            {

                            }
                            else
                            {
                                X5Y5.Image = GetImage();
                                AddToList("X5Y5");
                                ButtonX5.Enabled = false;
                            }
                        }
                        else
                        {
                            X5Y4.Image = GetImage();
                            AddToList("X5Y4");
                        }
                    }
                    else
                    {
                        X5Y3.Image = GetImage();
                        AddToList("X5Y3");
                    }
                }
                else
                {
                    X5Y2.Image = GetImage();
                    AddToList("X5Y2");
                }
            }
            else
            {
                X5Y1.Image = GetImage();
                AddToList("X5Y1");
            }

            

            ReverseUser();
        }

        private Image GetImage(bool getBlank = false)
        {
            if (getBlank)
            {
                return Properties.Resources.image_blank;
            }

            if (CurrentUser == "Yellow")
            {
                return Properties.Resources.image_yellow;
            }

            if (CurrentUser == "Red")
            {
                return Properties.Resources.image_red;
            }

            throw new ArgumentOutOfRangeException();
        }

        private void ReverseUser()
        {
            if (CurrentUserLabel.Text.Contains("won!") || CurrentUserLabel.Text.Contains("stalemate"))
            {
                
            }
            else
            {
                if (CurrentUser == "Yellow")
                {
                    CurrentUser = "Red";
                }
                else if (CurrentUser == "Red")
                {
                    CurrentUser = "Yellow";
                }

                CurrentUserLabel.Text = $"{CurrentUser}'s turn";
            }
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            coinList.Clear();
            redCoinList.Clear();
            yellowCoinList.Clear();
            coinList.Add("X1Y1", "Blank"); X1Y1.Image = Resources.image_blank;
            coinList.Add("X1Y2", "Blank"); X1Y2.Image = Resources.image_blank;
            coinList.Add("X1Y3", "Blank"); X1Y3.Image = Resources.image_blank;
            coinList.Add("X1Y4", "Blank"); X1Y4.Image = Resources.image_blank;
            coinList.Add("X1Y5", "Blank"); X1Y5.Image = Resources.image_blank;

            coinList.Add("X2Y1", "Blank"); X2Y1.Image = Resources.image_blank;
            coinList.Add("X2Y2", "Blank"); X2Y2.Image = Resources.image_blank;
            coinList.Add("X2Y3", "Blank"); X2Y3.Image = Resources.image_blank;
            coinList.Add("X2Y4", "Blank"); X2Y4.Image = Resources.image_blank;
            coinList.Add("X2Y5", "Blank"); X2Y5.Image = Resources.image_blank;

            coinList.Add("X3Y1", "Blank"); X3Y1.Image = Resources.image_blank;
            coinList.Add("X3Y2", "Blank"); X3Y2.Image = Resources.image_blank;
            coinList.Add("X3Y3", "Blank"); X3Y3.Image = Resources.image_blank;
            coinList.Add("X3Y4", "Blank"); X3Y4.Image = Resources.image_blank;
            coinList.Add("X3Y5", "Blank"); X3Y5.Image = Resources.image_blank;

            coinList.Add("X4Y1", "Blank"); X4Y1.Image = Resources.image_blank;
            coinList.Add("X4Y2", "Blank"); X4Y2.Image = Resources.image_blank;
            coinList.Add("X4Y3", "Blank"); X4Y3.Image = Resources.image_blank;
            coinList.Add("X4Y4", "Blank"); X4Y4.Image = Resources.image_blank;
            coinList.Add("X4Y5", "Blank"); X4Y5.Image = Resources.image_blank;

            coinList.Add("X5Y1", "Blank"); X5Y1.Image = Resources.image_blank;
            coinList.Add("X5Y2", "Blank"); X5Y2.Image = Resources.image_blank;
            coinList.Add("X5Y3", "Blank"); X5Y3.Image = Resources.image_blank;
            coinList.Add("X5Y4", "Blank"); X5Y4.Image = Resources.image_blank;
            coinList.Add("X5Y5", "Blank"); X5Y5.Image = Resources.image_blank;


            TaskDialogButton redButton = new("Red");
            TaskDialogButton yellowButton = new("Yellow");

            TaskDialogButton result = TaskDialog.ShowDialog(this, new TaskDialogPage()
            {
                Text = "Who should go first?",
                Buttons =
                {
                    redButton,
                    yellowButton
                },
                Icon = TaskDialogIcon.Information,
                Caption = "Connect Four"
            });

            if (result == redButton)
            {
                CurrentUser = "Red";
                CurrentUserLabel.Text = "Red's turn";
            }
            else if (result == yellowButton)
            {
                CurrentUser = "Yellow";
                CurrentUserLabel.Text = "Yellow's turn";
            }

            RestartButton.Visible = false;
            ButtonX1.Enabled = true;
            ButtonX2.Enabled = true;
            ButtonX3.Enabled = true;
            ButtonX4.Enabled = true;
            ButtonX5.Enabled = true;
        }
    }
}