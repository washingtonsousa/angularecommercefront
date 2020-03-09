using Core.Domain.EF.Entities;
using Core.Shared.Kernel.Events;
using Core.Shared.Kernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

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
        AssertionConcern.AssertNotEmpty(cliente.FlSexo, "Sexo é obrigatório"),
        AssertionConcern.AssertNotEmpty(cliente.FlTipoPessoa, "Tipo de pessoa é obrigatório"),
        AssertionConcern.AssertNotEmpty(cliente.DsRazaoSocial, "Razão social obrigatória")

        );
    }
  }
}
