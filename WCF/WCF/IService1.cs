using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        string Login(string username, string password);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        string AddMusic(string name, string artist, string album, Genres genre, int likes, int dislikes, string guid);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        List<Music> ListMusic();

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        string UpdateMusic(int id, string name, string artist, string album, Genres genre, int likes, int dislikes, string guid);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        string DeleteMusic(int id, string guid);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        string DeleteAllMusic(string guid);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void Logout(string uid);
    }
}
