using System;
using System.Formats.Asn1;
using System.Globalization;

// Estrutura Sequencial (entrada, processamento e saída)
//namespace exercicio1 {
    //class Program {
        //static void Main(string[] args) {
            // ------------- Atividade 1 -------------
            //int valor1, valor2, resultado;
            //valor1 = int.Parse(Console.ReadLine());
            //valor2 = int.Parse(Console.ReadLine());

            //resultado = valor1 + valor2;

            //Console.WriteLine("SOMA = " + resultado);

            //------------- Atividade 2-------------
            //double pi, raio, area;
            //pi = 3.14159;
            //raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //area = pi * Math.Pow(raio, 2);

            //Console.WriteLine("area = " + area.ToString("F4", CultureInfo.InvariantCulture));

            //------------- Atividade 3 -------------
            //int A, B, C, D, dif;
            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //C = int.Parse(Console.ReadLine());
            //D = int.Parse(Console.ReadLine());
            //dif = A * B - C * D;

            //Console.WriteLine("DIFERENÇA = " + dif);

            //------------- Atividade 4 -------------
            //int num, horas;
            //double salario;

            //num = int.Parse(Console.ReadLine());
            //horas = int.Parse(Console.ReadLine());
            //salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //salario = salario * horas;

            //Console.WriteLine("NUMBER = " + num);
            //Console.WriteLine("SALARY = U$" + salario.ToString("F2", CultureInfo.InvariantCulture));

            //------------- Atividade 5 -------------
            //int cod1, cod2, qte1, qte2;
            //double preco1, preco2, total;

            //string[] valores = Console.ReadLine().Split(' ');
            //cod1 = int.Parse(valores[0]);
            //qte1 = int.Parse(valores[1]);
            //preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //valores = Console.ReadLine().Split(' ');
            //cod2 = int.Parse(valores[0]);
            //qte2 = int.Parse(valores[1]);
            //preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //total = preco1 * qte1 + preco2 * qte2;

            //Console.WriteLine("VALOR A PAGAR : R$" + total.ToString("F2", CultureInfo.InvariantCulture));

            //------------- Atividade 6 ------------- 
            //double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;
            //double pi = 3.14159;

            //string[] area = Console.ReadLine().Split(' ');
            //A = double.Parse(area[0], CultureInfo.InvariantCulture);
            //B = double.Parse(area[1], CultureInfo.InvariantCulture);
            //C = double.Parse(area[2], CultureInfo.InvariantCulture);

            //triangulo = A * C / 2.0;
            //circulo = pi * C * C;
            //trapezio = (A + B) * C / 2.0;
            //quadrado = B * B;
            //retangulo = A * B;

            //Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            //Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        //}
    //}
//}

//Estrutura Condicional (if-else)
//namespace exercicio2{
    //class Program{
        //static void Main(string[] args){
            //------------- Atividade 1 -------------
            //int num1;
            //num1 = int.Parse(Console.ReadLine());

            //if (num1 >= 0){
            //Console.WriteLine("NAO NEGATIVO");
            //} else {
            //Console.WriteLine("NEGATIVO");
            //}

            //------------- Atividade 2 -------------
            //if (num1 % 2 == 0){
            //Console.WriteLine("PAR");
            //} else {
            //Console.WriteLine("IMPAR");
            //}

            //------------- Atividade 3 -------------
            //string[] mult = Console.ReadLine().Split(' ');
            //int A = int.Parse(mult[0]);
            //int B = int.Parse(mult[1]);

            //if (A % B == 0 || B % A == 0) {
            //Console.WriteLine("SAO MULTIPLOS");
            //} else {
            //Console.WriteLine("NAO SAO MULTIPLOS");
            //}

            //------------- Atividade 4 -------------

            //int horaA, horaB, duracao;
            //string[] hora = Console.ReadLine().Split(' ');
            //horaA = int.Parse(hora[0]);
            //horaB = int.Parse(hora[1]);

            //if (horaA < horaB) { 
            //duracao = horaB - horaA;
            //} else {
            //duracao = 24 - horaA + horaB;
            //}
            //Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");

            //------------- Atividade 5 -------------
            //string[] lanche = Console.ReadLine().Split(' ');
            //int pedido = int.Parse(lanche[0]);
            //int quant = int.Parse(lanche[1]);

            //double total;
            //if (pedido == 1) {
                //total = quant * 4.0;
            
            //} else if (pedido == 2) {
                //total = quant * 4.5;
            
            //} else if (pedido == 3) {
                //total = quant * 5.0;  
            
            //} else if (pedido == 4) {
                //total = quant * 2.0;
            //} else {
                //total = quant * 1.5;
            //}
            //Console.WriteLine("Total: R$" + total.ToString("F2", CultureInfo.InvariantCulture));

//Estrutura Repetitiva (while)
namespace exercicio3{
    class Program{
        static void Main(string[] args){
            //------------- Atividade 1 -------------

            //int senha = int.Parse(Console.ReadLine());

            //while (senha != 2002) {
            //Console.WriteLine("Senha Invalida");
            //senha = int.Parse(Console.ReadLine()); //Colocar essa linha para o programa não entrar em loop.
            //}
            //Console.WriteLine("Acesso Permitido");

            //------------- Atividade 2 -------------

            //string[] coord = Console.ReadLine().Split(' ');
            //int x = int.Parse(coord[0]);
            //int y = int.Parse(coord[1]);

            //while (x != 0 || y != 0) {
            //if (x > 0 && y > 0) {
            //Console.WriteLine("primeiro");
            //} else if (x < 0 && y > 0) {
            //Console.WriteLine("segundo");
            //} else if (x < 0 && y < 0) {
            //Console.WriteLine("terceiro");
            //} else {
            //Console.WriteLine("quarto");
            //}

            //coord = Console.ReadLine().Split(' ');
            //x = int.Parse(coord[0]);
            //y = int.Parse(coord[1]);

            //}

            //------------- Atividade 3 -------------

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int cont = int.Parse(Console.ReadLine());

            while (cont != 4) { 
                if (cont == 1) {
                    alcool++;
                } else if (cont == 2) {
                    gasolina++;                  
                } else if (cont == 3) { 
                    diesel++;
                }


                cont = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}