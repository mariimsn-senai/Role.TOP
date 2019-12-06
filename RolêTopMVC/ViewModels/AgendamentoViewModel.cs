using RolêTopMVC.Controllers;
using RolêTopMVC.ViewModels;

namespace RolêTopMVC.Models
{
    public class AgendamentoViewModel : BaseViewModel
    {
        public PacoteSimples PacoteSimples {get;set;}
        public  PacotePadrao PacotePadrao {get;set;}
        public PacotePremium PacotePremium {get;set;}
        
    }
}