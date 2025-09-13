using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Proyecto.mysql;

public class funciones
{
    public static int agregar(Paciente add)
    {
        int retorno = 0;
        MySqlCommand comando = new MySqlCommand(String.Format("insert into paciente(nombre, apellidoPat, apellidoMat, curp, domicilio, telefono, fechaNac) values('{0}','{1}','{2}','{3}','{4}', '{5}', '{6}')", add.nombre,add.apellidoPaterno, add.apellidoMaterno, add.curp, add.domicilio, add.telefono, add.fechaNac), conexion.obtenerConexion());
        retorno = comando.ExecuteNonQuery();
        return retorno;
    }

    public static List<Paciente> mostrar()
    {
        List<Paciente> lista = new List<Paciente>();
        MySqlCommand comando = new MySqlCommand(String.Format("select * from paciente"), conexion.obtenerConexion());
        MySqlDataReader reader = comando.ExecuteReader();

        while (reader.Read())
        {
            Paciente p = new Paciente();
            p.nombre = reader.GetString(0);
            p.apellidoPaterno = reader.GetString(1);
            p.apellidoMaterno = reader.GetString(2);
            p.curp = reader.GetString(3);
            p.domicilio = reader.GetString(4);
            p.telefono = reader.GetString(5);
            p.fechaNac = reader.GetString(6);
            lista.Add(p);
        }
        return lista;
    }

    public static List<Paciente> Buscar(string nombre, string curp)
    {
        List<Paciente> listaBuscar = new List<Paciente>();
        MySqlCommand comando = new MySqlCommand(String.Format("select * from paciente where nombre = '{0}' or curp = '{1}'", nombre, curp), conexion.obtenerConexion());
        MySqlDataReader reader = comando.ExecuteReader();
        while (reader.Read())
        {
            Paciente p = new Paciente();
            p.nombre = reader.GetString(0);
            p.apellidoPaterno = reader.GetString(1);
            p.apellidoMaterno = reader.GetString(2);
            p.curp = reader.GetString(3);
            p.domicilio = reader.GetString(4);
            p.telefono = reader.GetString(5);
            p.fechaNac = reader.GetString(6);
            listaBuscar.Add(p);
        }
        return listaBuscar;
    }

    //////////////////////////////////////////////////////////////////////////////////

    public static int agregarCita(Cita add)
    {
        int retorno = 0;
        MySqlCommand comando = new MySqlCommand(String.Format("insert into cita(dia, hora, nombred, nombrep) values('{0}','{1}','{2}','{3}')", add.dia, add.hora, add.nombreDoctor, add.nombrePaciente), conexion.obtenerConexion());
        retorno = comando.ExecuteNonQuery();
        return retorno;
    }


    public static List<Cita> mostrarCita()
    {
        List<Cita> lista = new List<Cita>();
        MySqlCommand comando = new MySqlCommand(String.Format("select * from cita"), conexion.obtenerConexion());
        MySqlDataReader reader = comando.ExecuteReader();

        while (reader.Read())
        {
            Cita c = new Cita();
            c.dia = reader.GetString(0);
            c.hora = reader.GetString(1);
            c.nombreDoctor = reader.GetString(2);
            c.nombrePaciente = reader.GetString(3);
            lista.Add(c);
        }
        return lista;
    }

    public static List<Cita> BuscarCita(string nombreP, string nombreD)
    {
        List<Cita> listaBuscar = new List<Cita>();
        MySqlCommand comando = new MySqlCommand(String.Format("select * from cita where nombreP = '{0}' or nombreD = '{1}'", nombreP, nombreD), conexion.obtenerConexion());
        MySqlDataReader reader = comando.ExecuteReader();
        while (reader.Read())
        {
            Cita c = new Cita();
            c.dia = reader.GetString(0);
            c.hora = reader.GetString(1);
            c.nombreDoctor = reader.GetString(2);
            c.nombrePaciente = reader.GetString(3);
            listaBuscar.Add(c);
        }
        return listaBuscar;
    }


    //////////////////////////////////////////////////////////////////////////

    public static int agregarRecepcionista(Recepcionista add)
    {
        int retorno = 0;
        MySqlCommand comando = new MySqlCommand(String.Format("insert into recepcionista(nombre, apellidopat, apellidomat, curp, domicilio, telefono, fechaNac, fechaIng) values ('{0}','{1}','{2}','{3}','{4}', '{5}', '{6}', '{7}')", add.nombre, add.apellidoPaterno, add.apellidoMaterno, add.curp, add.domicilio, add.telefono, add.fechaNac, add.fechaIng), conexion.obtenerConexion());
        retorno = comando.ExecuteNonQuery();
        return retorno;
    }


    public static List<Recepcionista> mostrarRecepcionista()
    {
        List<Recepcionista> lista = new List<Recepcionista>();
        MySqlCommand comando = new MySqlCommand(String.Format("select * from recepcionista"), conexion.obtenerConexion());
        MySqlDataReader reader = comando.ExecuteReader();

        while (reader.Read())
        {
            Recepcionista r = new Recepcionista();
            r.nombre = reader.GetString(0);
            r.apellidoPaterno = reader.GetString(1);
            r.apellidoMaterno = reader.GetString(2);
            r.curp = reader.GetString(3);
            r.domicilio = reader.GetString(4);
            r.telefono = reader.GetString(5);
            r.fechaNac = reader.GetString(6);
            r.fechaIng = reader.GetString(7);
            lista.Add(r);
        }
        return lista;
    }

    public static List<Recepcionista> BuscarRecepcionista(string nombre, string curp)
    {
        List<Recepcionista> listaBuscar = new List<Recepcionista>();
        MySqlCommand comando = new MySqlCommand(String.Format("select * from recepcionista where nombre = '{0}' or curp = '{1}'", nombre, curp), conexion.obtenerConexion());
        MySqlDataReader reader = comando.ExecuteReader();
        while (reader.Read())
        {
            Recepcionista r = new Recepcionista();
            r.nombre = reader.GetString(0);
            r.apellidoPaterno = reader.GetString(1);
            r.apellidoMaterno = reader.GetString(2);
            r.curp = reader.GetString(3);
            r.domicilio = reader.GetString(4);
            r.telefono = reader.GetString(5);
            r.fechaNac = reader.GetString(6);
            r.fechaIng = reader.GetString(7);
            listaBuscar.Add(r);
        }
        return listaBuscar;
    }

    //////////////////////////////////////////////////////////////

    public static int agregarDoctor(Doctor add)
    {
        int retorno = 0;
        MySqlCommand comando = new MySqlCommand(String.Format("insert into doctor(nombre, apellidopat, apellidomat, curp, domicilio, telefono, fechanac, fechaing,especialidad) values ('{0}','{1}','{2}','{3}','{4}', '{5}', '{6}', '{7}', '{8}')", add.nombre, add.apellidoPaterno, add.apellidoMaterno, add.curp, add.domicilio, add.telefono, add.fechaNac, add.fechaIng, add.especialidad), conexion.obtenerConexion());
        retorno = comando.ExecuteNonQuery();
        return retorno;
    }


    public static List<Doctor> mostrarDoctor()
    {
        List<Doctor> lista = new List<Doctor>();
        MySqlCommand comando = new MySqlCommand(String.Format("select * from doctor"), conexion.obtenerConexion());
        MySqlDataReader reader = comando.ExecuteReader();

        while (reader.Read())
        {
            Doctor d = new Doctor();
            d.nombre = reader.GetString(0);
            d.apellidoPaterno = reader.GetString(1);
            d.apellidoMaterno = reader.GetString(2);
            d.curp = reader.GetString(3);
            d.domicilio = reader.GetString(4);
            d.telefono = reader.GetString(5);
            d.fechaNac = reader.GetString(6);
            d.fechaIng = reader.GetString(7);
            d.especialidad = reader.GetString(8);
            lista.Add(d);
        }
        return lista;
    }

    public static List<Doctor> BuscarDoctor(string nombre, string curp)
    {
        List<Doctor> listaBuscar = new List<Doctor>();
        MySqlCommand comando = new MySqlCommand(String.Format("select * from doctor where nombre = '{0}' or curp = '{1}'", nombre, curp), conexion.obtenerConexion());
        MySqlDataReader reader = comando.ExecuteReader();
        while (reader.Read())
        {
            Doctor d = new Doctor();
            d.nombre = reader.GetString(0);
            d.apellidoPaterno = reader.GetString(1);
            d.apellidoMaterno = reader.GetString(2);
            d.curp = reader.GetString(3);
            d.domicilio = reader.GetString(4);
            d.telefono = reader.GetString(5);
            d.fechaNac = reader.GetString(6);
            d.fechaIng = reader.GetString(7);
            d.especialidad = reader.GetString(8);
            listaBuscar.Add(d);
        }
        return listaBuscar;
    }

    ///////////////////////////////////////////////


    public static int agregarExpediente(Expediente add)
    {
        int retorno = 0;
        MySqlCommand comando = new MySqlCommand(String.Format("insert into expediente(nombreD,nombreP, apellidoPaternoP, apellidoMaternoP, curpP, domicilioP, telefonoP, fechaNacP, padecimiento,comentario) values ('{0}','{1}','{2}','{3}','{4}', '{5}', '{6}', '{7}', '{8}', '{9}')", add.nombreD, add.nombreP, add.apellidoPaternoP, add.apellidoMaternoP, add.curpP, add.domicilioP, add.telefonoP, add.fechaNacP, add.padecimiento, add.comentario), conexion.obtenerConexion());
        retorno = comando.ExecuteNonQuery();
        return retorno;
    }


    public static List<Expediente> mostrarExpediente()
    {
        List<Expediente> lista = new List<Expediente>();
        MySqlCommand comando = new MySqlCommand(String.Format("select * from expediente"), conexion.obtenerConexion());
        MySqlDataReader reader = comando.ExecuteReader();

        while (reader.Read())
        {
            Expediente e = new Expediente();
            e.nombreD = reader.GetString(0);
            e.nombreP = reader.GetString(1);
            e.apellidoPaternoP = reader.GetString(2);
            e.apellidoMaternoP = reader.GetString(3);
            e.curpP = reader.GetString(4);
            e.domicilioP = reader.GetString(5);
            e.telefonoP = reader.GetString(6);
            e.fechaNacP = reader.GetString(7);
            e.padecimiento = reader.GetString(8);
            e.comentario = reader.GetString(9);
            lista.Add(e);
        }
        return lista;
    }

    public static List<Expediente> BuscarExpediente(string nombreP, string nombreD)
    {
        List<Expediente> listaBuscar = new List<Expediente>();
        MySqlCommand comando = new MySqlCommand(String.Format("select * from expediente where nombreP = '{0}' or curpP = '{1}'", nombreP, nombreD), conexion.obtenerConexion());
        MySqlDataReader reader = comando.ExecuteReader();
        while (reader.Read())
        {
            Expediente e = new Expediente();
            e.nombreD = reader.GetString(0);
            e.nombreP = reader.GetString(1);
            e.apellidoPaternoP = reader.GetString(2);
            e.apellidoMaternoP = reader.GetString(3);
            e.curpP = reader.GetString(4);
            e.domicilioP = reader.GetString(5);
            e.telefonoP = reader.GetString(6);
            e.fechaNacP = reader.GetString(7);
            e.padecimiento = reader.GetString(8);
            e.comentario = reader.GetString(9);
            listaBuscar.Add(e);
        }
        return listaBuscar;
    }
}
