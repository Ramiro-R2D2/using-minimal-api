using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace using_minimal_api.Models
{
    public class VeiculoEletrico : Veiculo
    {
        VeiculoEletrico(){
            setTipo(TipoVeiculo.eletrico);
        }
    }
}