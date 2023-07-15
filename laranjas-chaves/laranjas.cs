using System;

class Program {
  static void Main(string[] args) {
    int totalLaranjas = 4; // declaração da variável que armazena o número total de laranjas
    int laranjasComidas = 3; // declaração da variável que armazena o número de laranjas comidas
    int laranjasRestantes = totalLaranjas - laranjasComidas; // subtração do número de laranjas comidas do total de laranjas para obter o número de laranjas restantes
    Console.WriteLine("Sobraram " + laranjasRestantes + " laranjas."); // exibição do resultado
  }
}