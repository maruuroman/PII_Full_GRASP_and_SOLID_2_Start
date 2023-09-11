using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public void ImprimirReceta(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.GetSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        /*
        Utlizamos el principio SRP al separar la responsabilidad de imprimir la receta en esta clase por separado, sacandole
        la responsabilidad de imprimirse a si misma a la receta
        */
        }

    }
}