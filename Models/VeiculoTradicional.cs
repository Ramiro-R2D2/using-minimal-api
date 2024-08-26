using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace using_minimal_api.Models
{
    public class VeiculoTradicional : Veiculo
    {   
        VeiculoTradicional(){
            setTipo(TipoVeiculo.tradicional);
        }
    }
}