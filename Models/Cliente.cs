using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace using_minimal_api.Models
{
    public class Cliente
    {
        private int id{set; get;}
        private int cpf{set; get;}
        private String nome{set; get;}

        public void setId(int id){
            this.id = id;
        }
        public void setCpf(int cpf){
            this.cpf = cpf;
        }
        public void setNome(String nome){
            this.nome = nome;
        }
        public String getId(){
            return $"ID: {id}";
        }
        public String getNome(){
            return $"Nome: {nome}";
        }
    }
}