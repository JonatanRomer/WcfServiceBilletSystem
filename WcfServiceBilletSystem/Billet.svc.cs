using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BilletLibrary;

namespace WcfServiceBilletSystem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Billet" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Billet.svc or Billet.svc.cs at the Solution Explorer and start debugging.
    public class Billet : IBillet
    {
        public int BilPris()
        {
            var billet = new Bil();
            return billet.Pris();
        }

        public int BilPrisMedBizz()
        {
            var billet = new Bil();
            billet.BroBizz = true;
            return billet.Pris();
        }

        public int BilprisØresund()
        {
            var billet = new BilØreSund();
            return billet.Pris();
        }

        public int BilprisØresundBizz()
        {
            var billet = new BilØreSund();
            billet.BroBizz = true;
            return billet.Pris();
        }

        public int MCBizz()
        {
            var billet = new MC();
            billet.BroBizz = true;
            return billet.Pris();
        }

        public int MCPris()
        {
            var billet = new MC();
            return billet.Pris();
        }

        public int MCPrisØresundBizz()
        {
            var billet = new MCØresund();
            billet.BroBizz = true;
            return billet.Pris();
        }

        public int MCØresund()
        {
            var billet = new MCØresund();
            return billet.Pris();
        }

        public int MCØresundBizz()
        {
            var billet = new MCØresund();
            billet.BroBizz = true;
            return billet.Pris();
        }
    }
}
