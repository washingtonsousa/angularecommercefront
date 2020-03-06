using Core.Domain.EF.Entities;
using Core.Domain.Interfaces.Concrete.Specification;
using Core.Shared.Kernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Specification
{
  public class ClienteSpecification : IClienteSpecification
  {
    private IAssertionConcern _assertionConcern;

    public ClienteSpecification(IAssertionConcern assertionConcern)
    {
      _assertionConcern = assertionConcern;
    }


    /// <summary>
    /// Validação de usuário para cadastramento
    /// </summary>
    /// <param name="cliente"></param>
    /// <returns></returns>
    public bool ValidateForSubscription(Cliente cliente)
    {
      return _assertionConcern.IsSatisfiedBy(
        _assertionConcern.AssertNotEmpty(cliente.DsEmail, "Email, não pode ser nulo"),
        _assertionConcern.AssertNotEmpty(cliente.DsCpfCnpj, "É obrigatório preencher o documento /CPF/CNPJ"),
        _assertionConcern.AssertNotEmpty(cliente.NmCliente, "Nome é obrigatório"),
        _assertionConcern.AssertNotEmpty(cliente.DsCelular, "Celular obrigatório"),
        _assertionConcern.AssertNotEmpty(cliente.DsCelularDdd, "DDD Celular é obrigatório"),
        _assertionConcern.AssertNotEmpty(cliente.DsSenha, "Senha não pode ser núlo"),
        _assertionConcern.AssertNotNull(cliente.DtNascimento, "Data de nascimento é obrigatória"),
        _assertionConcern.AssertNotNull(cliente.FlSexo, "Sexo é obrigatório"),
        _assertionConcern.AssertNotNull(cliente.FlTipoPessoa, "Tipo de pessoa é obrigatório")
        );
    }

    /// <summary>
    /// Validação de usuário para cadastramento de pessoa jurídica
    /// </summary>
    /// <param name="cliente"></param>
    /// <returns></returns>
    public bool ValidateEnterpriseForSubscription(Cliente cliente)
    {
      return _assertionConcern.IsSatisfiedBy(

        _assertionConcern.AssertNotEmpty(cliente.DsEmail, "Email, não pode ser nulo"),
        _assertionConcern.AssertNotEmpty(cliente.DsCpfCnpj, "É obrigatório preencher o documento /CPF/CNPJ"),
        _assertionConcern.AssertNotEmpty(cliente.NmCliente, "Nome é obrigatório"),
        _assertionConcern.AssertNotEmpty(cliente.DsCelular, "Celular obrigatório"),
        _assertionConcern.AssertNotEmpty(cliente.DsCelularDdd, "DDD Celular é obrigatório"),
        _assertionConcern.AssertNotEmpty(cliente.DsSenha, "Senha não pode ser núlo"),
        _assertionConcern.AssertNotNull(cliente.DtNascimento, "Data de nascimento é obrigatória"),
        _assertionConcern.AssertNotEmpty(cliente.FlSexo, "Sexo é obrigatório"),
        _assertionConcern.AssertNotEmpty(cliente.FlTipoPessoa, "Tipo de pessoa é obrigatório"),
        _assertionConcern.AssertNotEmpty(cliente.DsRazaoSocial, "Razão social obrigatória")

        );
    }
  }
}
