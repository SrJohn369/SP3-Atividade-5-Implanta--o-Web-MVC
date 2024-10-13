namespace SP3_Atividade_5_Implanta__o_Web_MVC_.Models;


public class Fornecedor
{
    public int Id { get; set; }
    public string Cnpj { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }

    public Fornecedor(int id, string cnpj, string nome, string email)
    {
        this.Id = id;
        this.Cnpj = cnpj;
        this.Nome = nome;
        this.Email = email;
    }
}