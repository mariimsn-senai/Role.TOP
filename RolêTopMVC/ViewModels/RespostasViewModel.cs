namespace RolêTopMVC.ViewModels
{
    public class RespostasViewModel
    {
        public string Mensagem {get;set;}

        public RespostasViewModel()
        {

        }

        public RespostasViewModel(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }

}