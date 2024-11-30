using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace using_minimal_api.Models
{
    public class VeiculoHibrido : Veiculo
    {
        VeiculoHibrido(){
            setTipo(TipoVeiculo.hibrido);
            setCondicao(CondicaoVeiculo.novo);
            setKm(0);
        }
    }
}