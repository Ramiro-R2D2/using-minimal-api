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
        private CondicaoVeiculoEnum condicao;
        private int kmRodados { get; set; }
        private TipoVeiculoEnum tipo;
        private bool alugado = false;
        private decimal preco{get; set;}
        private int veiculoId{get; set;}

        public void getVeiculoId(int veiculoId){
            this.veiculoId = veiculoId;
        } 
        
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

        public void setTipo(TipoVeiculoEnum tipo){
            this.tipo = tipo;
        }
        public void setCondicao(CondicaoVeiculoEnum condicao){
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

        public String infoVeiculo(){
            return $"{nome} - marca \n  Placa:{placa} \n Condição:{condicao} \n Tipo:{tipo}";
        }
    }
}