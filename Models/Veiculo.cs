using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Net.Http.Headers;

namespace using_minimal_api.Models
{
    public abstract class Veiculo
    {
        private String? placa { get; set; }
        private String? nome { get; set; }
        private String? marca { get; set; }
        private CondicaoVeiculo condicao;
        private int kmRodados { get; set; }
        private TipoVeiculo tipo;
        private bool alugado = false;
        private decimal preco{get; set;}
        
        public String getNome(){
            return nome;
        }
        public void setNome(String nome){
            this.nome = nome;
        }

        public String getMarca(){
            return marca;
        }

        public void setMarca(String marca){
            this.marca = marca;
        }

        public void setTipo(TipoVeiculo tipo){
            this.tipo = tipo;
        }
        public void setCondicao(CondicaoVeiculo condicao){
            this.condicao = condicao;
        }

        public void setAluguel(){
            alugado = true;
        }

        public decimal getPreco(){
            return preco;
        }
        public void setPreco(decimal preco){
            this.preco = preco;
        }
         public int getKM(){
            return kmRodados;
        }
        public void setKm(int kmRodados){
            this.kmRodados = kmRodados;
        }
    }
}