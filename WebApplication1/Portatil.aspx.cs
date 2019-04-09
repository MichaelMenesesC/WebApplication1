using DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        DTPortatil dev = new DTPortatil();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindData();
            }

        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {

            try
            {
                GetValues(1);
            BL.BLPortatil.Inst.Insertar(dev);
            BindData();
            }
            catch (Exception ee)
            {

                throw;
            }
        }

        private void GetValues(int proceso)
        {
            // 1 = insertar & actualizar
            // 2 = eliminar
            if (proceso == 1)
            {
               // dev.Id = Convert.ToInt32(DropDownList5.SelectedValue);
                dev.Marca = Convert.ToInt32(DropDownList3.SelectedValue.ToString()); 
                dev.Modelo = Convert.ToInt32(DropDownList4.SelectedValue.ToString()); 
                dev.Tipo = DropDownList1.SelectedValue.ToString();
                dev.Lanzamiento = Convert.ToDateTime(TextBox1.Text);
                dev.MemoryVideoGB = Convert.ToInt32(txtmem.Text);
                dev.Pantalla = Convert.ToInt32(txtPantalla.Text);
                dev.SistOp = DropDownList2.SelectedValue.ToString();
                dev.Procesador = Convert.ToInt32(txtprocesador.Text);
                dev.Ram = Convert.ToInt32(txtram.Text);
                dev.Camara = Convert.ToInt32(txtcamara.Text);
                dev.Cantidad_usb = Convert.ToInt32(txtusb.Text);
                dev.Bateria = Convert.ToInt32(txtbateria.Text);
            }

                if (proceso == 2)
                {
                    dev.Id = Convert.ToInt32(DropDownList5.SelectedValue);
                }

            if (proceso == 3)
            {
                dev.Id = Convert.ToInt32(DropDownList5.SelectedValue);
                dev.Marca = Convert.ToInt32(DropDownList3.SelectedValue);
                dev.Modelo = Convert.ToInt32(DropDownList4.SelectedValue);
                dev.Tipo = DropDownList1.SelectedValue.ToString();
                dev.Lanzamiento = Convert.ToDateTime(TextBox1.Text);
                dev.MemoryVideoGB = Convert.ToInt32(txtmem.Text);
                dev.Pantalla = Convert.ToInt32(txtPantalla.Text);
                dev.SistOp = DropDownList2.SelectedValue.ToString();
                dev.Procesador = Convert.ToInt32(txtprocesador.Text);
                dev.Ram = Convert.ToInt32(txtram.Text);
                dev.Camara = Convert.ToInt32(txtcamara.Text);
                dev.Cantidad_usb = Convert.ToInt32(txtusb.Text);
                dev.Bateria = Convert.ToInt32(txtbateria.Text);
            }

            if (proceso == 4)
            {
                dev.Id = Convert.ToInt32(DropDownList5.SelectedValue);
            }

        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues(4);
                Session["lista"] = BL.BLPortatil.Inst.MostrarPorID(dev);

                List<DTPortatil> milista = (List<DTPortatil>)Session["lista"];

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues(3);
                BL.BLPortatil.Inst.Actualizar(dev);
                BindData();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                GetValues(2);
                BL.BLPortatil.Inst.Eliminar(dev);
                BindData();

            }
            catch (Exception ee)
            {

                throw;
            }
        }

        private void BindData()
        {

            Session["lista"] = BL.BLPortatil.Inst.MostrarTodo();

            List<DTPortatil> milista = (List<DTPortatil>)Session["lista"];


            gvData.DataSource = milista;
            gvData.DataBind();
        }

        protected void gvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gvData.SelectedRow;

            DropDownList5.Text = Convert.ToString(gvData.SelectedRow.Cells[1].Text);
            DropDownList3.Text = Convert.ToString(gvData.SelectedRow.Cells[2].Text);
            DropDownList4.Text = Convert.ToString(gvData.SelectedRow.Cells[3].Text);
            DropDownList1.Text = Convert.ToString(gvData.SelectedRow.Cells[4].Text);
            txtmem.Text = Convert.ToString(gvData.SelectedRow.Cells[5].Text);
            TextBox1.Text = Convert.ToString(gvData.SelectedRow.Cells[6].Text);
            txtPantalla.Text = Convert.ToString(gvData.SelectedRow.Cells[7].Text);
            DropDownList2.Text = Convert.ToString(gvData.SelectedRow.Cells[8].Text);
            txtprocesador.Text = Convert.ToString(gvData.SelectedRow.Cells[9].Text);
            txtram.Text = Convert.ToString(gvData.SelectedRow.Cells[10].Text);
            txtcamara.Text = Convert.ToString(gvData.SelectedRow.Cells[11].Text);
            txtusb.Text = Convert.ToString(gvData.SelectedRow.Cells[12].Text);
            txtbateria.Text = Convert.ToString(gvData.SelectedRow.Cells[13].Text);
            //txtmem.Text = Convert.ToString(gvData.DataKeys[row.RowIndex].Values["memoriavideointernaGB"]);



        }
    }
}