﻿using System;
using System.Collections.Generic;

namespace Marketplace.Core.Data.EF.Entities
{
    public partial class TbUploadImagem
    {
        public int IdUploadImagem { get; set; }
        public string DsArquivo { get; set; }
        public string DsUrl { get; set; }
    }
}
