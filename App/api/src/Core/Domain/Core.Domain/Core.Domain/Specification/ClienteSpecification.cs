using Core.Domain.EF.Entities;
using Core.Shared.Kernel.Events;

namespace Core.Domain.Specification
{
  public static class ClienteSpecification 
  {

    /// <summary>
    /// Validação de usuário para cadastramento
    /// </summary>
    /// <param name="cliente"></param>
    /// <returns></returns>
    public static bool ValidateForSubscription(this Cliente cliente)
    {
      return AssertionConcern.IsSatisfiedBy(
        AssertionConcern.AssertNotEmpty(cliente.DsEmail, "Email, não pode ser nulo"),
        AssertionConcern.AssertNotEmpty(cliente.DsCpfCnpj, "É obrigatório preencher o documento /CPF/CNPJ"),
        AssertionConcern.AssertNotEmpty(cliente.NmCliente, "Nome é obrigatório"),
        AssertionConcern.AssertNotEmpty(cliente.DsCelular, "Celular obrigatório"),
        AssertionConcern.AssertNotEmpty(cliente.DsCelularDdd, "DDD Celular é obrigatório"),
        AssertionConcern.AssertNotEmpty(cliente.DsSenha, "Senha não pode ser núlo"),
        AssertionConcern.AssertNotNull(cliente.DtNascimento, "Data de nascimento é obrigatória"),
        AssertionConcern.AssertNotNull(cliente.FlSexo, "Sexo é obrigatório"),
        AssertionConcern.AssertNotNull(cliente.FlTipoPessoa, "Tipo de pessoa é obrigatório")
        );
    }

    /// <summary>
    /// Validação de usuário para cadastramento de pessoa jurídica
    /// </summary>
    /// <param name="cliente"></param>
    /// <returns></returns>
    public static bool ValidateEnterpriseForSubscription(this Cliente cliente)
    {
      return AssertionConcern.IsSatisfiedBy(

        AssertionConcern.AssertNotEmpty(cliente.DsEmail, "Email, não pode ser nulo"),
        AssertionConcern.AssertNotEmpty(cliente.DsCpfCnpj, "É obrigatório preencher o documento /CPF/CNPJ"),
        AssertionConcern.AssertNotEmpty(cliente.NmCliente, "Nome é obrigatório"),
        AssertionConcern.AssertNotEmpty(cliente.DsCelular, "Celular obrigatório"),
        AssertionConcern.AssertNotEmpty(cliente.DsCelularDdd, "DDD Celular é obrigatório"),
        AssertionConcern.AssertNotEmpty(cliente.DsSenha, "Senha não pode ser núlo"),
        AssertionConcern.AssertNotNull(cliente.DtNascimento, "Data de nascimento é obrigatória"),
        AssertionConcern.AssertNotEmpty(cliente.FlTipoPessoa, "Tipo de pessoa é obrigatório"),
        AssertionConcern.AssertNotEmpty(cliente.DsRazaoSocial, "Razão social obrigatória")

        );
    }


    public static bool ValidateForUpdate(this Cliente cliente)
    {
      return AssertionConcern.IsSatisfiedBy(
        AssertionConcern.AssertNotEmpty(cliente.DsCelular, "Celular obrigatório"),
        AssertionConcern.AssertNotEmpty(cliente.DsCelularDdd, "DDD Celular é obrigatório"),
        AssertionConcern.AssertNotNull(cliente.DtNascimento, "Data de nascimento é obrigatória"),
        AssertionConcern.AssertNotNull(cliente.FlSexo, "Sexo é obrigatório")
        );
    }

    /// <summary>
    /// Validação de usuário para cadastramento de pessoa jurídica
    /// </summary>
    /// <param name="cliente"></param>
    /// <returns></returns>
    public static bool ValidateEnterpriseForUpdate(this Cliente cliente)
    {
      return AssertionConcern.IsSatisfiedBy(

        AssertionConcern.AssertNotEmpty(cliente.DsCelular, "Celular obrigatório"),
        AssertionConcern.AssertNotEmpty(cliente.DsCelularDdd, "DDD Celular é obrigatório"),
        AssertionConcern.AssertNotNull(cliente.DtNascimento, "Data de nascimento é obrigatória")

        );
    }


    /// <summary>
    /// Valida se cliente Logado corresponde ao cliente fornecido
    /// </summary>
    /// <param name="cliente"></param>
    /// <param name="Id"></param>
    /// <returns></returns>
    public static bool ValidateLoggedInUser(this Cliente cliente, int Id)
    {
      return AssertionConcern.IsSatisfiedBy(

           AssertionConcern.AssertFalse((cliente.IdCliente != Id), "Ação não permitida")
      );
    }

  }
}
