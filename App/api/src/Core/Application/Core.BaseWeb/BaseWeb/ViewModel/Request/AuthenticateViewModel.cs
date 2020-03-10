using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Core.BaseWeb.ViewModel
{
  public class AuthenticateViewModel
  {

    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }

  }
}
