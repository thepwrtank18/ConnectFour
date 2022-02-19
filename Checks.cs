using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectFour
{
    internal class Checks
    {
        public static bool CheckYellow(string checkType)
        {


            if (checkType == "vertical")
            {
                #region vertical

                // X1 area
                if (Form1.yellowCoinList.Contains("X1Y1"))
                {
                    if (Form1.yellowCoinList.Contains("X1Y2"))
                    {
                        if (Form1.yellowCoinList.Contains("X1Y3"))
                        {
                            if (Form1.yellowCoinList.Contains("X1Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X1Y2"))
                {
                    if (Form1.yellowCoinList.Contains("X1Y3"))
                    {
                        if (Form1.yellowCoinList.Contains("X1Y4"))
                        {
                            if (Form1.yellowCoinList.Contains("X1Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // X2 area
                if (Form1.yellowCoinList.Contains("X2Y1"))
                {
                    if (Form1.yellowCoinList.Contains("X2Y2"))
                    {
                        if (Form1.yellowCoinList.Contains("X2Y3"))
                        {
                            if (Form1.yellowCoinList.Contains("X2Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X2Y2"))
                {
                    if (Form1.yellowCoinList.Contains("X2Y3"))
                    {
                        if (Form1.yellowCoinList.Contains("X2Y4"))
                        {
                            if (Form1.yellowCoinList.Contains("X2Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // X3 area
                if (Form1.yellowCoinList.Contains("X3Y1"))
                {
                    if (Form1.yellowCoinList.Contains("X3Y2"))
                    {
                        if (Form1.yellowCoinList.Contains("X3Y3"))
                        {
                            if (Form1.yellowCoinList.Contains("X3Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X3Y2"))
                {
                    if (Form1.yellowCoinList.Contains("X3Y3"))
                    {
                        if (Form1.yellowCoinList.Contains("X3Y4"))
                        {
                            if (Form1.yellowCoinList.Contains("X3Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // X4 area
                if (Form1.yellowCoinList.Contains("X4Y1"))
                {
                    if (Form1.yellowCoinList.Contains("X4Y2"))
                    {
                        if (Form1.yellowCoinList.Contains("X4Y3"))
                        {
                            if (Form1.yellowCoinList.Contains("X4Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X4Y2"))
                {
                    if (Form1.yellowCoinList.Contains("X4Y3"))
                    {
                        if (Form1.yellowCoinList.Contains("X4Y4"))
                        {
                            if (Form1.yellowCoinList.Contains("X4Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // X5 area
                if (Form1.yellowCoinList.Contains("X5Y1"))
                {
                    if (Form1.yellowCoinList.Contains("X5Y2"))
                    {
                        if (Form1.yellowCoinList.Contains("X5Y3"))
                        {
                            if (Form1.yellowCoinList.Contains("X5Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X5Y2"))
                {
                    if (Form1.yellowCoinList.Contains("X5Y3"))
                    {
                        if (Form1.yellowCoinList.Contains("X5Y4"))
                        {
                            if (Form1.yellowCoinList.Contains("X5Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                #endregion
            }
            else if (checkType == "horizontal")
            {
                #region horizontal
                // Y1 area
                if (Form1.yellowCoinList.Contains("X1Y1"))
                {
                    if (Form1.yellowCoinList.Contains("X2Y1"))
                    {
                        if (Form1.yellowCoinList.Contains("X3Y1"))
                        {
                            if (Form1.yellowCoinList.Contains("X4Y1"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X2Y1"))
                {
                    if (Form1.yellowCoinList.Contains("X3Y1"))
                    {
                        if (Form1.yellowCoinList.Contains("X4Y1"))
                        {
                            if (Form1.yellowCoinList.Contains("X5Y1"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // Y2 area
                if (Form1.yellowCoinList.Contains("X1Y2"))
                {
                    if (Form1.yellowCoinList.Contains("X2Y2"))
                    {
                        if (Form1.yellowCoinList.Contains("X3Y2"))
                        {
                            if (Form1.yellowCoinList.Contains("X4Y2"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X2Y2"))
                {
                    if (Form1.yellowCoinList.Contains("X3Y2"))
                    {
                        if (Form1.yellowCoinList.Contains("X4Y2"))
                        {
                            if (Form1.yellowCoinList.Contains("X5Y2"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // Y3 area
                if (Form1.yellowCoinList.Contains("X1Y3"))
                {
                    if (Form1.yellowCoinList.Contains("X2Y3"))
                    {
                        if (Form1.yellowCoinList.Contains("X3Y3"))
                        {
                            if (Form1.yellowCoinList.Contains("X4Y3"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X2Y3"))
                {
                    if (Form1.yellowCoinList.Contains("X3Y3"))
                    {
                        if (Form1.yellowCoinList.Contains("X4Y3"))
                        {
                            if (Form1.yellowCoinList.Contains("X5Y3"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // Y4 area
                if (Form1.yellowCoinList.Contains("X1Y4"))
                {
                    if (Form1.yellowCoinList.Contains("X2Y4"))
                    {
                        if (Form1.yellowCoinList.Contains("X3Y4"))
                        {
                            if (Form1.yellowCoinList.Contains("X4Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X2Y4"))
                {
                    if (Form1.yellowCoinList.Contains("X3Y4"))
                    {
                        if (Form1.yellowCoinList.Contains("X4Y4"))
                        {
                            if (Form1.yellowCoinList.Contains("X5Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // Y5 area
                if (Form1.yellowCoinList.Contains("X1Y5"))
                {
                    if (Form1.yellowCoinList.Contains("X2Y5"))
                    {
                        if (Form1.yellowCoinList.Contains("X3Y5"))
                        {
                            if (Form1.yellowCoinList.Contains("X4Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X2Y5"))
                {
                    if (Form1.yellowCoinList.Contains("X3Y5"))
                    {
                        if (Form1.yellowCoinList.Contains("X4Y5"))
                        {
                            if (Form1.yellowCoinList.Contains("X5Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }
                #endregion
            }
            else if (checkType == "diagonal")
            {
                #region diagonal
                // -> area
                if (Form1.yellowCoinList.Contains("X1Y1"))
                {
                    if (Form1.yellowCoinList.Contains("X2Y2"))
                    {
                        if (Form1.yellowCoinList.Contains("X3Y3"))
                        {
                            if (Form1.yellowCoinList.Contains("X4Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X2Y1"))
                {
                    if (Form1.yellowCoinList.Contains("X3Y2"))
                    {
                        if (Form1.yellowCoinList.Contains("X4Y3"))
                        {
                            if (Form1.yellowCoinList.Contains("X5Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X1Y2"))
                {
                    if (Form1.yellowCoinList.Contains("X2Y3"))
                    {
                        if (Form1.yellowCoinList.Contains("X3Y4"))
                        {
                            if (Form1.yellowCoinList.Contains("X4Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // <- area
                if (Form1.yellowCoinList.Contains("X5Y1"))
                {
                    if (Form1.yellowCoinList.Contains("X4Y2"))
                    {
                        if (Form1.yellowCoinList.Contains("X3Y3"))
                        {
                            if (Form1.yellowCoinList.Contains("X2Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X4Y1"))
                {
                    if (Form1.yellowCoinList.Contains("X3Y2"))
                    {
                        if (Form1.yellowCoinList.Contains("X2Y3"))
                        {
                            if (Form1.yellowCoinList.Contains("X1Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.yellowCoinList.Contains("X5Y2"))
                {
                    if (Form1.yellowCoinList.Contains("X4Y3"))
                    {
                        if (Form1.yellowCoinList.Contains("X3Y4"))
                        {
                            if (Form1.yellowCoinList.Contains("X2Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }
                #endregion
            }

            return false;
        }

        public static bool CheckRed(string checkType)
        {
            if (checkType == "vertical")
            {
                #region vertical

                // X1 area
                if (Form1.redCoinList.Contains("X1Y1"))
                {
                    if (Form1.redCoinList.Contains("X1Y2"))
                    {
                        if (Form1.redCoinList.Contains("X1Y3"))
                        {
                            if (Form1.redCoinList.Contains("X1Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X1Y2"))
                {
                    if (Form1.redCoinList.Contains("X1Y3"))
                    {
                        if (Form1.redCoinList.Contains("X1Y4"))
                        {
                            if (Form1.redCoinList.Contains("X1Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // X2 area
                if (Form1.redCoinList.Contains("X2Y1"))
                {
                    if (Form1.redCoinList.Contains("X2Y2"))
                    {
                        if (Form1.redCoinList.Contains("X2Y3"))
                        {
                            if (Form1.redCoinList.Contains("X2Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X2Y2"))
                {
                    if (Form1.redCoinList.Contains("X2Y3"))
                    {
                        if (Form1.redCoinList.Contains("X2Y4"))
                        {
                            if (Form1.redCoinList.Contains("X2Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // X3 area
                if (Form1.redCoinList.Contains("X3Y1"))
                {
                    if (Form1.redCoinList.Contains("X3Y2"))
                    {
                        if (Form1.redCoinList.Contains("X3Y3"))
                        {
                            if (Form1.redCoinList.Contains("X3Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X3Y2"))
                {
                    if (Form1.redCoinList.Contains("X3Y3"))
                    {
                        if (Form1.redCoinList.Contains("X3Y4"))
                        {
                            if (Form1.redCoinList.Contains("X3Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // X4 area
                if (Form1.redCoinList.Contains("X4Y1"))
                {
                    if (Form1.redCoinList.Contains("X4Y2"))
                    {
                        if (Form1.redCoinList.Contains("X4Y3"))
                        {
                            if (Form1.redCoinList.Contains("X4Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X4Y2"))
                {
                    if (Form1.redCoinList.Contains("X4Y3"))
                    {
                        if (Form1.redCoinList.Contains("X4Y4"))
                        {
                            if (Form1.redCoinList.Contains("X4Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // X5 area
                if (Form1.redCoinList.Contains("X5Y1"))
                {
                    if (Form1.redCoinList.Contains("X5Y2"))
                    {
                        if (Form1.redCoinList.Contains("X5Y3"))
                        {
                            if (Form1.redCoinList.Contains("X5Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X5Y2"))
                {
                    if (Form1.redCoinList.Contains("X5Y3"))
                    {
                        if (Form1.redCoinList.Contains("X5Y4"))
                        {
                            if (Form1.redCoinList.Contains("X5Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                #endregion
            }
            else if (checkType == "horizontal")
            {
                #region horizontal
                // Y1 area
                if (Form1.redCoinList.Contains("X1Y1"))
                {
                    if (Form1.redCoinList.Contains("X2Y1"))
                    {
                        if (Form1.redCoinList.Contains("X3Y1"))
                        {
                            if (Form1.redCoinList.Contains("X4Y1"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X2Y1"))
                {
                    if (Form1.redCoinList.Contains("X3Y1"))
                    {
                        if (Form1.redCoinList.Contains("X4Y1"))
                        {
                            if (Form1.redCoinList.Contains("X5Y1"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // Y2 area
                if (Form1.redCoinList.Contains("X1Y2"))
                {
                    if (Form1.redCoinList.Contains("X2Y2"))
                    {
                        if (Form1.redCoinList.Contains("X3Y2"))
                        {
                            if (Form1.redCoinList.Contains("X4Y2"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X2Y2"))
                {
                    if (Form1.redCoinList.Contains("X3Y2"))
                    {
                        if (Form1.redCoinList.Contains("X4Y2"))
                        {
                            if (Form1.redCoinList.Contains("X5Y2"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // Y3 area
                if (Form1.redCoinList.Contains("X1Y3"))
                {
                    if (Form1.redCoinList.Contains("X2Y3"))
                    {
                        if (Form1.redCoinList.Contains("X3Y3"))
                        {
                            if (Form1.redCoinList.Contains("X4Y3"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X2Y3"))
                {
                    if (Form1.redCoinList.Contains("X3Y3"))
                    {
                        if (Form1.redCoinList.Contains("X4Y3"))
                        {
                            if (Form1.redCoinList.Contains("X5Y3"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // Y4 area
                if (Form1.redCoinList.Contains("X1Y4"))
                {
                    if (Form1.redCoinList.Contains("X2Y4"))
                    {
                        if (Form1.redCoinList.Contains("X3Y4"))
                        {
                            if (Form1.redCoinList.Contains("X4Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X2Y4"))
                {
                    if (Form1.redCoinList.Contains("X3Y4"))
                    {
                        if (Form1.redCoinList.Contains("X4Y4"))
                        {
                            if (Form1.redCoinList.Contains("X5Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // Y5 area
                if (Form1.redCoinList.Contains("X1Y5"))
                {
                    if (Form1.redCoinList.Contains("X2Y5"))
                    {
                        if (Form1.redCoinList.Contains("X3Y5"))
                        {
                            if (Form1.redCoinList.Contains("X4Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X2Y5"))
                {
                    if (Form1.redCoinList.Contains("X3Y5"))
                    {
                        if (Form1.redCoinList.Contains("X4Y5"))
                        {
                            if (Form1.redCoinList.Contains("X5Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }
                #endregion
            }
            else if (checkType == "diagonal")
            {
                #region diagonal
                // -> area
                if (Form1.redCoinList.Contains("X1Y1"))
                {
                    if (Form1.redCoinList.Contains("X2Y2"))
                    {
                        if (Form1.redCoinList.Contains("X3Y3"))
                        {
                            if (Form1.redCoinList.Contains("X4Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X2Y1"))
                {
                    if (Form1.redCoinList.Contains("X3Y2"))
                    {
                        if (Form1.redCoinList.Contains("X4Y3"))
                        {
                            if (Form1.redCoinList.Contains("X5Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X1Y2"))
                {
                    if (Form1.redCoinList.Contains("X2Y3"))
                    {
                        if (Form1.redCoinList.Contains("X3Y4"))
                        {
                            if (Form1.redCoinList.Contains("X4Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }

                // <- area
                if (Form1.redCoinList.Contains("X5Y1"))
                {
                    if (Form1.redCoinList.Contains("X4Y2"))
                    {
                        if (Form1.redCoinList.Contains("X3Y3"))
                        {
                            if (Form1.redCoinList.Contains("X2Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X4Y1"))
                {
                    if (Form1.redCoinList.Contains("X3Y2"))
                    {
                        if (Form1.redCoinList.Contains("X2Y3"))
                        {
                            if (Form1.redCoinList.Contains("X1Y4"))
                            {
                                return true;
                            }
                        }
                    }
                }

                if (Form1.redCoinList.Contains("X5Y2"))
                {
                    if (Form1.redCoinList.Contains("X4Y3"))
                    {
                        if (Form1.redCoinList.Contains("X3Y4"))
                        {
                            if (Form1.redCoinList.Contains("X2Y5"))
                            {
                                return true;
                            }
                        }
                    }
                }
                #endregion
            }

            return false;
        }
    }
}
