import { ProdutoModel } from 'src/shared/models/produto.model';

function getProdutoByCodigo(Codigo) : ProdutoModel {
            let produto =  Produtos.filter((produto) => {
                return produto.Codigo == Codigo;
        })[0];

        return produto;
}


export const Produtos =  [{

    Nome: "Nebacetin Pomada 50g",
    Codigo: "67184",
    Preco_Por: 10.00,
    Quantidade: 0,
    Marca: {

        Nome: "Farmacêutica Takeda"

    },

    Imagem: { 
        UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7896641804595.jpg",
        Nome: "" },
    ImagemPrincipal: { 
        UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7896641804595.jpg",
        Nome: "" },
    Imagens: [
        { 
            UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7896641804595.jpg",
            Nome: "" }
    ]},
{

    Nome: "Gel Lubrificante KY 50g",
    Codigo: "66971",
    Preco_Por: 500.00,
    Quantidade: 0,
    Marca: {

        Nome: "RECKITT BENCKISER"

    },

    Imagem: { 
        UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891010020927.jpg",
        Nome: "" },
    ImagemPrincipal: { 
        UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891010020927.jpg",
        Nome: "" },
    Imagens: [
        { 
            UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891010020927.jpg",
            Nome: "" },
  
       
    ]},
    {

        Nome: "Alergomine Solucao Oral 0,4mg 120mL",
        Codigo: "79233",
        Preco_Por: 500.00,
        Quantidade: 0,
        Marca: {
    
            Nome: "CIMED"
    
        },
    
        Imagem: { 
            UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/46919.jpg",
            Nome: "" },
        ImagemPrincipal: { 
            UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/46919.jpg",
            Nome: "" },
        Imagens: [
            { 
                UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/46919.jpg",
                Nome: "" },
      
           
        ]},
        {

            Nome: "Advil 200mg 20 Comprimidos",
            Codigo: "65929",
            Preco_Por: 10.00,
            Quantidade: 0,
            Marca: {
        
                Nome: "PFizer"
        
            },
        
            Imagem: { 
                UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891045038386.jpg",
                Nome: "" },
            ImagemPrincipal: { 
                UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891045038386.jpg",
                Nome: "" },
            Imagens: [
                { 
                    UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891045038386.jpg",
                    Nome: "" },
          
               
            ]},
        
            {

                Nome: "Advil 200mg 20 Comprimidos",
                Codigo: "65929",
                Preco_Por: 10.00,
                Quantidade: 0,
                Marca: {
            
                    Nome: "PFizer"
            
                },
            
                Imagem: { 
                    UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891045038386.jpg",
                    Nome: "" },
                ImagemPrincipal: { 
                    UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891045038386.jpg",
                    Nome: "" },
                Imagens: [
                    { 
                        UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891045038386.jpg",
                        Nome: "" },
              
                   
                ]},
                {

                    Nome: "Advil 200mg 20 Comprimidos",
                    Codigo: "65929",
                    Preco_Por: 10.00,
                    Quantidade: 0,
                    Marca: {
                
                        Nome: "PFizer"
                
                    },
                
                    Imagem: { 
                        UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891045038386.jpg",
                        Nome: "" },
                    ImagemPrincipal: { 
                        UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891045038386.jpg",
                        Nome: "" },
                    Imagens: [
                        { 
                            UrlRelativa: "/BACKOFFICE/Uploads/Produto/Super/7891045038386.jpg",
                            Nome: "" },
                  
                       
                    ]}
        ];


export const ProdutoDetalhes = [ 
{ Produto : getProdutoByCodigo("67184"),
  Descricoes: [  
      { Texto: '<p style="text-align:justify">INDICAÇÃO:&nbsp;No tratamento de infecções bacterianas da pele e de mucosas, causadas por microorganismos sensíveis: piodermites, impetigo, eczemas infectados, otite externa, infecções da mucosa nasal, furúnculos, antraz, ectima, abscessos, acne infectada, intertrigo, úlceras cutâneas e queimaduras infectadas. Na profilaxia de infecções cutâneo-mucosas decorrentes de ferimentos cortantes (inclusive cirúrgicos), abrasões, queimaduras pouco extensas, dentre outros. CONTRA INDICAÇÃO:&nbsp;Não deve ser usado nos casos de hipersensibilidade à neomicina ou a outros antibióticos aminoglicosídeos, na insuficiência renal grave, em lesões preexistentes no aparelho auditivo ou no sistema labiríntico; durante a gravidez ou a amamentação. Não deve ser utilizado em bebês prematuros e em recém-nascidos, pela função renal pouco desenvolvida, o que leva ao prolongamento da meia-vida do produto e, também, pela potencial ototoxicidade e nefrotoxicidade deste medicamento. Este medicamento está contraindicado para uso por bebês prematuros, recém-nascidos e lactantes.</p>',
  Tipo: "Informações"}]},
{ Produto : getProdutoByCodigo("66971"),
Descricoes : [{ Texto: '<p style="text-align:justify">INDICAÇÃO:&nbsp;No tratamento de infecções bacterianas da pele e de mucosas, causadas por microorganismos sensíveis: piodermites, impetigo, eczemas infectados, otite externa, infecções da mucosa nasal, furúnculos, antraz, ectima, abscessos, acne infectada, intertrigo, úlceras cutâneas e queimaduras infectadas. Na profilaxia de infecções cutâneo-mucosas decorrentes de ferimentos cortantes (inclusive cirúrgicos), abrasões, queimaduras pouco extensas, dentre outros. CONTRA INDICAÇÃO:&nbsp;Não deve ser usado nos casos de hipersensibilidade à neomicina ou a outros antibióticos aminoglicosídeos, na insuficiência renal grave, em lesões preexistentes no aparelho auditivo ou no sistema labiríntico; durante a gravidez ou a amamentação. Não deve ser utilizado em bebês prematuros e em recém-nascidos, pela função renal pouco desenvolvida, o que leva ao prolongamento da meia-vida do produto e, também, pela potencial ototoxicidade e nefrotoxicidade deste medicamento. Este medicamento está contraindicado para uso por bebês prematuros, recém-nascidos e lactantes.</p>',
  Tipo: "Informações"}]},
{ Produto : getProdutoByCodigo("79233"),
Descricoes : [{ Texto: '<p style="text-align:justify">INDICAÇÃO:&nbsp;No tratamento de infecções bacterianas da pele e de mucosas, causadas por microorganismos sensíveis: piodermites, impetigo, eczemas infectados, otite externa, infecções da mucosa nasal, furúnculos, antraz, ectima, abscessos, acne infectada, intertrigo, úlceras cutâneas e queimaduras infectadas. Na profilaxia de infecções cutâneo-mucosas decorrentes de ferimentos cortantes (inclusive cirúrgicos), abrasões, queimaduras pouco extensas, dentre outros. CONTRA INDICAÇÃO:&nbsp;Não deve ser usado nos casos de hipersensibilidade à neomicina ou a outros antibióticos aminoglicosídeos, na insuficiência renal grave, em lesões preexistentes no aparelho auditivo ou no sistema labiríntico; durante a gravidez ou a amamentação. Não deve ser utilizado em bebês prematuros e em recém-nascidos, pela função renal pouco desenvolvida, o que leva ao prolongamento da meia-vida do produto e, também, pela potencial ototoxicidade e nefrotoxicidade deste medicamento. Este medicamento está contraindicado para uso por bebês prematuros, recém-nascidos e lactantes.</p>',
  Tipo: "Informações"} ] }, 
{ Produto :  getProdutoByCodigo("65929"),
Descricoes : [{ Texto: '<p style="text-align:justify">INDICAÇÃO:&nbsp;No tratamento de infecções bacterianas da pele e de mucosas, causadas por microorganismos sensíveis: piodermites, impetigo, eczemas infectados, otite externa, infecções da mucosa nasal, furúnculos, antraz, ectima, abscessos, acne infectada, intertrigo, úlceras cutâneas e queimaduras infectadas. Na profilaxia de infecções cutâneo-mucosas decorrentes de ferimentos cortantes (inclusive cirúrgicos), abrasões, queimaduras pouco extensas, dentre outros. CONTRA INDICAÇÃO:&nbsp;Não deve ser usado nos casos de hipersensibilidade à neomicina ou a outros antibióticos aminoglicosídeos, na insuficiência renal grave, em lesões preexistentes no aparelho auditivo ou no sistema labiríntico; durante a gravidez ou a amamentação. Não deve ser utilizado em bebês prematuros e em recém-nascidos, pela função renal pouco desenvolvida, o que leva ao prolongamento da meia-vida do produto e, também, pela potencial ototoxicidade e nefrotoxicidade deste medicamento. Este medicamento está contraindicado para uso por bebês prematuros, recém-nascidos e lactantes.</p>',
  Tipo: "Informações"}]}

];


