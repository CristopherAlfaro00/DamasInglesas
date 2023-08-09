using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProgra5Csharp
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        int num;
        PictureBox[,] PicBox;
        string color = "r", k = "", B1 = "", B2 = "",k2="";


        public class DamasPieza
        {
            public bool IsQueen { get; set; }
            public string Color { get; set; }

            public DamasPieza(bool isQueen, string color)
            {
                IsQueen = isQueen;
                Color = color;
            }
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            PictureBox picbox = sender as PictureBox;

            if (picbox.Image != null && Jugador1.ReadOnly && Jugador2.ReadOnly)
            {
                int fromRow = Convert.ToInt32(picbox.Name.Split(' ')[0]);
                int fromCol = Convert.ToInt32(picbox.Name.Split(' ')[1]);

                int toRow = 0;
                int toCol = 0;

                if (B1 != "")
                {
                    int x = Convert.ToInt32(B1.Split(' ')[0]);
                    int y = Convert.ToInt32(B1.Split(' ')[1]);
                    PicBox[x, y].Image = null;
                }

                if (B2 != "")
                {
                    int x = Convert.ToInt32(B2.Split(' ')[0]);
                    int y = Convert.ToInt32(B2.Split(' ')[1]);
                    PicBox[x, y].Image = null;
                }


                // Verifica si la casilla de destino es válida y realiza el movimiento.
                if (EsMovimientoValido(fromRow, fromCol, toRow, toCol))
                {
                    MovePiece(fromRow, fromCol, toRow, toCol);

                    if (toRow == 0 || toRow == num - 1)
                    {
                        DamasPieza piece = GetPieceFromPictureBox(PicBox[toRow, toCol]);
                        if (!piece.IsQueen)
                        {
                            piece.IsQueen = true;
                            if (piece.Color == "r")
                            { 
                                PicBox[toRow, toCol].Image = Properties.Resources.roja;
                                PicBox[toRow, toCol].Name = $"{toRow} {toCol} r";
                            }
                            else
                                PicBox[toRow, toCol].Image = Properties.Resources.azul;
                            PicBox[toRow, toCol].Name = $"{toRow} {toCol} g";
                        }
                    }

                    if (EsFinDelJuego())
                    {
                        // Aquí puedes mostrar un mensaje de victoria o reiniciar el juego.
                    }
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {
            

            PanelJuego.Visible = false;
            for (int h = 0; h < num; h++)
                for (int l = 0; l < num; l++)
                {
                    if (h < (num / 2) - 1 && PicBox[h, l].BackColor == Color.Black) { PicBox[h , l].Image = Properties.Resources.roja; PicBox[h, l].Name = h     + " " + l + " r"; }
                    else            if (h > (num / 2) && PicBox[h, l].BackColor == Color.Black)
                    {
                        PicBox[h, l].Image = Properties.Resources.azul ; PicBox[h, l].Name = h + " " + l + " g";
                    }
                    if (h == ((num / 2) - 1) || h     == (num / 2)) PicBox[h, l].Image = null;
                }
            labelJug1.Text = "0";
            labelJug2.Text = "0";
            Jugador1.ReadOnly = false;
            Jugador2.ReadOnly = false;
            Jugador1.Text = "";
            Jugador2.Text = "";
            Jugador1.BackColor = Color.White;
            Jugador2.BackColor = Color.White;
            Jugador1.ForeColor = Color.Black;
            Jugador2.ForeColor = Color.Black;
            rojo = 0;
            azul = 0;
        }

        private void Help_Click(object sender, CancelEventArgs e)
        {
            
            MessageBox.Show(
                "Cada jugador controla las piezas de un color situadas al comienzo a cada lado del tablero. " +
                "Empieza el juego las blancas." +
                "\r\n\r\nLos movimientos se hacen alternativamente, uno por jugador, en diagonal, una sola casilla y en sentido de avance, o sea, hacia el campo del oponente." +
                "\r\n\r\nSi un jugador consigue llevar una de sus fichas al lado contrario del tablero cambiará dicho peón por una dama o reina (dos fichas del mismo color una encima de otra)." +
                "\r\n\r\nLa dama o reina se mueve también en diagonal, pero puede hacerlo hacia delante y hacia atrás. Según las opciones de mesa puede avanzar una casilla como el peón o recorrer cualquier número de casillas mientras estén libres." +
                " Nunca podrá saltar por encima de sus propias piezas o dos piezas contiguas.", "Como se juega \r\n\r\n");

        }

        private void Jugador1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TextBox t = sender as TextBox;
                if (t.Text != "" && Jugador1.Text != Jugador2.Text)
                {
                    t.ReadOnly = true;
                    if (t.Name == "Jugador2")
                        t.BackColor = Color.Blue;
                    else
                        t.BackColor = Color.Red;
                    t.ForeColor = Color.White;
                }
                else
                {
                    if (t.Text == "")
                        MessageBox.Show("El nombre del jugador no puede estar vacio");
                    if (Jugador1.Text == Jugador2.Text)
                        MessageBox.Show("Los jugadores no pueden tener el mismo nombre");
                }
            }

        }

        int azul  =0,rojo=0;


       

        private void MovePiece(int fromRow, int fromCol, int toRow, int toCol)
        {
            // Obtiene la ficha de la posición de origen
            DamasPieza piece = GetPieceFromPictureBox(PicBox[fromRow, fromCol]);

            // Actualiza la imagen de la casilla de destino y la casilla de origen
            PicBox[toRow, toCol].Image = PicBox[fromRow, fromCol].Image;
            PicBox[fromRow, fromCol].Image = null;

            // Actualiza el nombre de la casilla de destino con el color de la ficha
            string colorName = (piece.Color == "r") ? "roja" : "azul";
            string queen = (piece.IsQueen) ? "_reina" : "";
            PicBox[toRow, toCol].Name = $"{toRow} {toCol} {colorName}{queen}";
        }

        
        private DamasPieza GetPieceFromPictureBox(PictureBox picbox)
        {
            string[] nameParts = picbox.Name.Split(' ');
            string color = nameParts[2].Substring(0, 1);
            bool isQueen = nameParts[2].Contains("_reina");

            return new DamasPieza(isQueen, color);
        }

        private bool EsMovimientoValido(int fromRow, int fromCol, int toRow, int toCol)
        {
            DamasPieza piece = GetPieceFromPictureBox(PicBox[fromRow, fromCol]);

            int rowDifference = Math.Abs(toRow - fromRow);
            int colDifference = Math.Abs(toCol - fromCol);

            if (rowDifference != colDifference)
            {
                return false;
            }

            int rowDirection = (toRow > fromRow) ? 1 : -1;
            int colDirection = (toCol > fromCol) ? 1 : -1;

            // Movimiento válido para ficha normal
            if (!piece.IsQueen)
            {
                // Movimiento hacia adelante
                if (rowDirection == -1)
                {
                    if (rowDifference == 1 && colDifference == 1 && PicBox[toRow, toCol].Image == null)
                    {
                        return true;
                    }
                }
                // Movimiento hacia atrás (si se convierte en reina)
                else if (rowDirection == 1 && piece.Color == "r")
                {
                    if (rowDifference == 1 && colDifference == 1 && PicBox[toRow, toCol].Image == null)
                    {
                        return true;
                    }
                }
            }

            // Movimiento válido para reina
            else
            {
                if (rowDifference > 0 && colDifference > 0)
                {
                    int steps = rowDifference;
                    int currentRow = fromRow + rowDirection;
                    int currentCol = fromCol + colDirection;

                    for (int i = 1; i < steps; i++)
                    {
                        if (PicBox[currentRow, currentCol].Image != null)
                        {
                            return false;
                        }
                        currentRow += rowDirection;
                        currentCol += colDirection;
                    }

                    if (PicBox[toRow, toCol].Image == null)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        private bool EsFinDelJuego()
        {
            bool jugador1SinMovimientos = true;
            bool jugador2SinMovimientos = true;

            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    if (PicBox[row, col].Image != null && PicBox[row, col].Name.Contains("r"))
                    {
                        if (EsMovimientoValido(row, col, row + 1, col + 1) || EsMovimientoValido(row, col, row + 1, col - 1))
                        {
                            jugador1SinMovimientos = false;
                            break;
                        }
                    }

                    if (PicBox[row, col].Image != null && PicBox[row, col].Name.Contains("g"))
                    {
                        if (EsMovimientoValido(row, col, row - 1, col + 1) || EsMovimientoValido(row, col, row - 1, col - 1))
                        {
                            jugador2SinMovimientos = false;
                            break;
                        }
                    }
                }

                if (!jugador1SinMovimientos && !jugador2SinMovimientos)
                {
                    break;
                }
            }

            return jugador1SinMovimientos || jugador2SinMovimientos;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            

            //Hacer que el panel de jugar cambie de color
            panel1.Parent = this;
            panel1.BringToFront();
            Jugar.Click += (sender2, e2) => {
                panel1.Visible = false;

            };

            Jugar.MouseHover += (sender3, e3) => {
                Label l = sender3 as Label;
                l.ForeColor = Color.DarkRed;
                panel1.BackColor = Color.White;
            };
            Jugar.MouseLeave += (sender3, e3) => {
                Label l = sender3 as Label;
                l.ForeColor = Color.White;
                panel1.BackColor = Color.DarkRed;
            };
            //********************************************
            //Creacion del tablero
            num = 8;
            PicBox = new PictureBox[num, num];
            int izquierda = 2, arriba = 2;
            Color[] colors = new Color[] { Color.White, Color.Black };
            for (int i = 0; i < num; i++)
            {
                izquierda = 2;
                if (i % 2 == 0) { colors[0] = Color.White; colors[1] = Color.Black; }
                else { colors[0] = Color.Black; colors[1] = Color.White; }
                //******************************************************
                //Agregar las fichas
                for (int j = 0; j < num; j++)
                {
                    

                    PicBox[i, j] = new PictureBox();
                   
                    PicBox[i, j].BackColor = colors[(j % 2 == 0) ? 1 : 0];
                    PicBox[i, j].Location = new Point(izquierda, arriba);
                   
                    PicBox[  i, j].Size = new Size(60, 60);

                    izquierda += 60;
                    PicBox[i, j].Name = i + " " + j;

                    if (i < (num / 2) - 1 && PicBox[i, j].BackColor == Color.Black) { PicBox[i, j].Image = Properties.Resources.roja; PicBox[i, j].Name += " r"; }
                    else if (i > (num / 2) && PicBox[i, j].BackColor == Color.Black)
                    {
                        PicBox[i, j].Image = Properties.Resources.azul; PicBox[i, j].Name += " g ";
                    }
                    PicBox[i, j].SizeMode = PictureBoxSizeMode.Zoom;

                    PicBox[i, j].MouseHover += (sender2, e2) =>
                    {
                        PictureBox p = sender2 as PictureBox;
                        if (p.Image != null) p.BackColor = Color.FromArgb(255, 64, 64, 64);
                    };
                    //cambio de fondo al pasar el mouse por el cuadro de ficha
                    PicBox[i, j].MouseLeave += (sender2, e2) =>
                    {
                        PictureBox p = sender2 as PictureBox;
                        if (p.Image != null) p.BackColor = Color.Black;
                    };
                    //******************************************************
                    //Separacion de las fichas para elegir
                    PicBox[i, j].Click += (sender3, e3) =>
                    {
                       

                        if (Jugador1.ReadOnly && Jugador2.ReadOnly)
                        {
                          
                            PictureBox picbox = sender3 as PictureBox;
                          
                            if (picbox.Image != null)
                            {
                                int c = (picbox.Name.Split(' ')[2] == "r") ? 1 : -1;
                                int x = Convert.ToInt32(picbox.Name.Split(' ')[0]);
                                int y = Convert.ToInt32(picbox.Name.Split(' ')[1]);
                                
                                string[] nameParts = picbox.Name.Split(' ');
                                if (nameParts.Length >= 3 && nameParts[2] == "b")
                                {
                                    if (color == "r") color = "g";
                                    else color = "r";             
                                   

                                    string[] kParts = k.Split(' ');
                                    if (kParts.Length >= 3 && kParts[2] == "r")
                                    {
                                        picbox.Image = Properties.Resources.roja;
                                        picbox.Name = picbox.Name.Replace("b", "r");

                                        if(x == 0)
                                        {
                                            picbox.Image = Properties.Resources.roja;
                                            picbox.Name.Replace("r","q");
                                        
                                        }
                                    }

                                    else
                                    if (kParts.Length >= 3 && kParts[2] == "g")
                                    {

                                        picbox.Image = Properties.Resources.azul;
                                        picbox .Name = picbox.Name.Replace("b", "g");
                                    }

                                    B1 = $"{x + c} {y + 1}";
                                    B2 = $"{x + c} {y - 1}";
                                    F();


                                    PicBox[x, y].Image = null;
                                    if (k2 != "")
                                    {
                                        int k2x = Convert.ToInt32(k2.Split(' ')[0]);
                                        int k2y = Convert.ToInt32(k2.Split(' ')[1]);

                                        PicBox[x, y].Image = null;

                                        if (k2.Split(' ')[2] == "r") rojo++;
                                        else azul++;
                                        labelJug1.Text = azul.ToString();
                                        labelJug2.Text = rojo.ToString();

                                        if (rojo >= 12)
                                        {
                                            labelw.Text = "Felicidades ganaste!! " + Jugador2.Text;
                                            PanelJuego.Visible = true;
                                        }
                                        else
                                        if (azul >= 12)
                                        {
                                            labelw.Text = "Felicidades ganaste!! " + Jugador1.Text;
                                            PanelJuego.Visible = true;
                                        }
                                            k2 = "";
                                    }

                                }
                                else
                                //Separacion de las fichas para elegir
                                if (picbox.Name.Split(' ')[2] == color)
                                {
                                  
                                    try
                                    {
                                        if (PicBox[x + c, y + 1].Image == null)
                                        {
                                            PicBox[x + c, y + 1].Image = Properties.Resources.b;
                                            PicBox[x + c, y + 1].Name = $"{x + c} {y + 1} b";
                                            B1 = $"{x + c} {y + 1}";
                                        }
                                        else
                                            if (PicBox[x + c, y + 1].Name.Split(' ')[2] != picbox.Name.Split(' ')[2]
                                                && PicBox[x + (c * 2), y + 2].Image == null)
                                        {
                                            int k2x = x + c;
                                            int k2y = y + 1;
                                            PicBox[x + (c * 2), y + 2].Image = Properties.Resources.b;
                                            PicBox[x + (c * 2), y + 2].Name = $"{x + (c * 2)} {y + 2} b";
                                            B1 = $"{x + (c * 2)} {y + 2}";

                                            k2 = $"{k2x} {k2y} {PicBox[k2x, k2y].Name.Split(' ')[2]}";
                                        }

                                    }
                                    catch { }
                                    try
                                    {
                                        if (PicBox[x + c, y - 1].Image == null)
                                        {
                                            PicBox[x + c, y - 1].Image = Properties.Resources.b;
                                            PicBox[x + c, y - 1].Name = $"{x + c} {y - 1} b";
                                            B2 = $"{x + c} {y - 1}";
                                        }
                                        else
                                            if (PicBox[x + c, y - 1].Name.Split(' ')[2] != picbox.Name.Split(' ')[2]
                                              && PicBox[x + (c * 2), y - 2].Image == null)

                                        {
                                            int k2x = x + c;
                                            int k2y = y - 1;
                                            PicBox[x + (c * 2), y - 2].Image = Properties.Resources.b;
                                            PicBox[x + (c * 2), y - 2].Name = $"{x + (c * 2)} {y - 2} b";
                                            B2 = $"{x + (c * 2)} {y - 2}";

                                            k2 = $"{k2x} {k2y} {PicBox[k2x, k2y].Name.Split(' ')[2]}";
                                        }
                                      }
                                        

                                    
                                    catch { }
                                    //******************************
                                }
                            }
                        }
                    };

                    G.Controls.Add(PicBox[i, j]);

                }
                arriba += 60;

            }
          

        }
        public void F()
        {
            if (B1 != "")
            {
                int x = Convert.ToInt32(B1.Split(' ')[0]);
                int y = Convert.ToInt32(B1.Split(' ')[1]);

                // Si la casilla está dentro de los límites del tablero
                if (x >= 0 && x < num && y >= 0 && y < num)
                {
                    PicBox[x, y].Image = null;
                    PicBox[x, y].Name = x + " " + y;
                }
            }
            if (B2 != "")
            {
                int x = Convert.ToInt32(B2.Split(' ')[0]);
                int y = Convert.ToInt32(B2.Split(' ')[1]);

                // Si la casilla está dentro de los límites del tablero
                if (x >= 0 && x < num && y >= 0 && y < num)
                {
                    PicBox[x, y].Image = null;
                    PicBox[x, y].Name = x + " " + y;
                }
            }
            B1 = "";
            B2 = "";
        }

    }



}
}
