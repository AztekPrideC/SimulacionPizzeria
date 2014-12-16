using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int numero;

        Cola cola;
        public Form1()
        {
            InitializeComponent();
            numero = random.Next(100, 200);
            cola=new Cola(numero);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
            int contadorClientesPerididos = 0;
            string prueba = "";
            string pizzaTam="";
            string pizzaSab = "";
            string tipoCliente = "";
            string clienteSatisfecho = "";
    Random random2= new Random ();
            int [] numeroDeClientes = new int[ numero];
            
            for (int i = 1; i < numero; i++) {
              int timepoTardado =random2.Next(50, 170);
                int tiempolimiteDeLaPersona=random2.Next(100,150);
            int tipo=random2.Next(1,5);
                if (tipo==1){
                   pizzaTam="chica";
                } else if (tipo==2){
                pizzaTam="mediana";
                }else if (tipo==3){
                pizzaTam="grande";
                
                }else if (tipo==4){
                
                pizzaTam="extra grande";
                
                }else if (tipo==5){
                
                pizzaTam="jumbo";
                
                }

                int sabor = random2.Next(1, 5);
                if (tipo == 1)
                {
                    pizzaSab = "Hawuiana";
                }
                else if (tipo == 2)
                {
                    pizzaSab = "Peperoni";
                }
                else if (tipo == 3)
                {
                    pizzaSab = "Mexicana";

                }
                else if (tipo == 4)
                {

                    pizzaSab = "Carnes frias";

                }


       

         int tipoclientee = random2.Next(0,10);

         if (tipoclientee <= 4) {

             tipoCliente = "Vip";
         }
         else if (tipoclientee <= 10) {

             tipoCliente = "normal";
         
         }
                //



         if (tiempolimiteDeLaPersona >= timepoTardado)
         {

             clienteSatisfecho = "si";
        
         }
         else {
 
             clienteSatisfecho = "no";
         
         }


         if (clienteSatisfecho.Equals("si"))
         {
             Persona cliente = new Persona(clienteSatisfecho, pizzaTam, pizzaSab);
             prueba += cliente.clienteSatisfecho + " " + cliente.pedido + " " + cliente.clase + Convert.ToString(i);
             cola.encolar(prueba);     
            

         }
         else {

             contadorClientesPerididos++;
         }

       
            }


            double porcentajedeclientesperdidos = Convert.ToDouble(contadorClientesPerididos) / Convert.ToDouble(numero);
            string porcentaje = Convert.ToString(porcentajedeclientesperdidos);

            textBox1.Text = porcentaje[0] + "." + porcentaje[2] + porcentaje[3] + "%";

           
    }
    }
}