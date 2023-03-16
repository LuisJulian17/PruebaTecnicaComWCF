using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface myUsuarioIService
{

    [OperationContract]

    int NuevoUsuario(Usuario usuario);

    [OperationContract]
    int EditarUsuario(Usuario usuario);
    [OperationContract]
    int EliminarUsuario(int idUsuario);
    [OperationContract]
    Usuario buscarUsuario(int idUsuario);
    [OperationContract]
    List<Usuario> ListarUsuarios();

}

[DataContract]
public class Usuario
{
	int _Id;
	string _Nom;
    string _FechaN ;

	string _Sexo;

    [DataMember]
    public int Id
    {
        get
        {
            return _Id;
        }

        set
        {
            _Id = value;
        }
    }
    [DataMember]
    public string Nom
    {
        get
        {
            return _Nom;
        }

        set
        {
            _Nom = value;
        }
    }
    [DataMember]
    public string FechaN
    {
        get
        {
            return _FechaN;
        }

        set
        {
            _FechaN = value;
        }
    }
    [DataMember]
    public string Sexo
    {
        get
        {
            return _Sexo;
        }

        set
        {
            _Sexo = value;
        }
    }
}
