using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MamaCJs.Persistance
{
    public class PizzaPriceRespository
    {
        public static  DTO.PizzaPriceDTO GetPizzaPrices()
        {
            var db = new MamaCJsDbEntities();
            var prices = db.PizzaPrices.First();
            var dto = convertToDTO(prices);
            return dto;


        }

        private static DTO.PizzaPriceDTO convertToDTO(PizzaPrice pizzaPrice)
        {
            var dto = new DTO.PizzaPriceDTO();

            dto.SmallSizeCost = pizzaPrice.SmallSizeCost;
            dto.MediumSizeCost = pizzaPrice.MediumSizeCost;
            dto.LargeSizeCost = pizzaPrice.LargeSizeCost;

            dto.RegularCrustCost = pizzaPrice.RegularCrustCost;
            dto.ThickCrustCost = pizzaPrice.ThickCrustCost;
            dto.ThinCrustCost = pizzaPrice.ThinCrustCost;

            dto.SausageCost = pizzaPrice.SausageCost;
            dto.PepperoniCost = pizzaPrice.PepperoniCost;
            dto.OnionsCost = pizzaPrice.OnionsCost;
            dto.GreenpeppersCost = pizzaPrice.GreenpeppersCost;

            return dto;
        }
    }
}
