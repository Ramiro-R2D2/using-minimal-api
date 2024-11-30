using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace using_minimal_api.Models
{
    public class Locacao
    {
        public int locacaoId { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFim { get; set; }
        public decimal valorTotal{ get; set; }

        public required Veiculo veiculo { get; set; }
        public required Cliente cliente { get; set; }
        public int clienteId { get; set; }
        public int veiculoId { get; set; }
        public List<int> listaId = new List<int>();
        public static void verLista(){
            // TODO: Finalizar a visualização da lista
        }
        public String reservar(int id){
            if(!listaId.Contains(id)){
                return "Carro não encontrado";
            }
            

            return "Carro reservado";
        }
    }
}