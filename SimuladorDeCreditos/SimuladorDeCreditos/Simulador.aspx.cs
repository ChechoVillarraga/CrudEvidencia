using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace SimuladorDeCreditos
{
    public partial class Simulador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BCalcular_Click(object sender, EventArgs e)
        {
            int monto, plazo;
            double cuota, interes = 0, saldoInicial = 0, capital = 0, intereses = 0, saldoFinal = 0;
            monto = int.Parse(TBmonto.Text);
            switch (DDLTipoCredito.SelectedIndex)
            {
                case 0:
                    interes = 0.01;
                    break;
                case 1:
                    interes = 0.012;
                    break;
                case 2:
                    interes = 0.016;
                    break;

            }
            plazo = int.Parse(TBPlazo.Text);
            cuota = (monto * interes + Math.Pow(1 + interes, plazo))/(Math.Pow(1+interes,plazo)-1);
            DataSet ds = new DataSet();
            ds.Tables.Add("Proyeccion");
            ds.Tables[0].Columns.Add("Mes");
            ds.Tables[0].Columns.Add("Saldo Inicial");
            ds.Tables[0].Columns.Add("Cuota");
            ds.Tables[0].Columns.Add("Intereses");
            ds.Tables[0].Columns.Add("Saldo Final");
            for (int i = 0; i < plazo; i++)
            {
                DataRow fila = ds.Tables[0].NewRow();
                fila[0] = i + 1;
                if (i==0)
                {
                    saldoInicial = monto;
                }
                else
                {
                    saldoInicial = saldoFinal;
                }
                fila[1] = Math.Round(saldoInicial, 0);
                fila[2] = Math.Round(cuota, 0);
                interes = interes * saldoInicial;
                fila[3] = Math.Round(interes, 0);
                capital = cuota - interes;
                fila[4] = Math.Round(capital, 0);
                saldoFinal = saldoInicial - capital;
                fila[5] = Math.Round(saldoFinal, 0);
                ds.Tables[0].Rows.Add(fila);
            }
            GVtabla.DataSource = ds.Tables[0];
            GVtabla.DataBind();



        }
    }
}