using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lista1PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    exercicio 1
            //    int m, cm, mm;
            //    Console.WriteLine("digite o nmr de metros: ");
            //    m = int.Parse(Console.ReadLine());
            //    cm = m * 100;
            //    mm = m * 1000;
            //    Console.WriteLine(m + " m sao iguais a:" + cm + " centimetros: " + mm + " milimetros:");
            //    Console.ReadKey();

            //exercicio 2
            //int f1, resInt;
            //float f2, resFloat;
            //Console.WriteLine("entre com o valor do Fahrenheit");
            //f1 = int.Parse(Console.ReadLine());
            //Console.WriteLine( "Entre com o Fahrenheit float: " );
            //f2 = float.Parse(Console.ReadLine());

            //resInt = (f1 - 32) * (5 / 9);
            //resFloat = (f2 - 32.0f) * (5.0f/ 9.0f);

            //Console.WriteLine("resultado do float: " +resFloat);
            //Console.WriteLine("resultado do int: " +resInt);


            ////exercicio 3
            //float h, p, h1, r;
            //Console.WriteLine( "digite seu peso: " );
            //p = float.Parse(Console.ReadLine());
            //Console.WriteLine("digite a sua altura: ");
            //h = float.Parse(Console.ReadLine());
            //h1 = h * h;
            //r = p / h1;
            //Console.WriteLine(r);

            //exercicio4
            //float n1, n2, n3, p1, p2, p3, nmr1, nmr2, nmr3, media;
            //console.writeline("digite o valor da 1 nota: ");
            //n1 = float.parse(console.readline());
            //console.writeline("digite o valor da 2 nota: ");
            //n2 = float.parse(console.readline());
            //console.writeline("digite o valor da 3 nota: ");
            //n3 = float.parse(console.readline());


            //console.writeline("digite o valor do 1 peso: ");
            //p1 = float.parse(console.readline());
            //console.writeline("digite o valor do 2 peso: ");
            //p2 = float.parse(console.readline());
            //console.writeline("digite o valor do 3 peso: ");
            //p3 = float.parse(console.readline());

            //nmr1 = n1 * p1;
            //nmr2 = n2 * p2;
            //nmr3 = n3 * p3;

            //media=(nmr1 + nmr2 + nmr3) / (p1 + p2 + p3);
            //console.writeline(media);
        }
        //exercicio 4

        //double n1, n2, n3, p1, p2, p3, mp;

        //Console.WriteLine("Digite a nota 1: ");
        //n1 = double.Parse(Console.ReadLine());
        //Console.WriteLine("Digite a peso 1: ");
        //p1 = double.Parse(Console.ReadLine());
        //Console.WriteLine("Digite a nota 2: ");
        //n2 = double.Parse(Console.ReadLine());
        //Console.WriteLine("Digite a peso 2: ");
        //p2 = double.Parse(Console.ReadLine());
        //Console.WriteLine("Digite a nota 3: ");
        //n3 = double.Parse(Console.ReadLine());
        //Console.WriteLine("Digite a peso 3: ");
        //p3 = double.Parse(Console.ReadLine());
        //Console.WriteLine("Digite a nota 2: ");

        //mp = (n1 * p1 + n2 * p2 + n3 * p3) / (p1 + p2 + p3);

        //Console.WriteLine("O valor da média ponderada é: " + mp);


        //exercicio 5

        //double dist, tam, v;

        //Console.WriteLine("Digite a distancia em metros: ");
        //dist = double.Parse(Console.ReadLine());
        //Console.WriteLine("Digite o tempo em segundos: ");
        //tam = double.Parse(Console.ReadLine());
        //v = d / t;

        //Console.WriteLine("A velocidade é: " + v + "m/s" );

        //exercicio 6

        //double sal, aument;

        //Console.WriteLine("Digite seu salário: ");
        //sal = double.Parse(Console.ReadLine());
        //aument = s * 0.25 + s;

        //Console.WriteLine("O valor do salário líquido é : " + a);

        //exercicio 7

        //double dol, cot, real;

        //Console.WriteLine("O valor em dolares: ");
        //dol = double.Parse(Console.ReadLine());
        //Console.WriteLine("Digite a cotação do dolar para real: ");
        //cot = double.Parse(Console.ReadLine());
        //real = cot / dol;

        //Console.WriteLine("O valor em reais é: R$" + r);

        //exercicio 8

        //int num, tn, dn, rn;

        //Console.WriteLine("Digite o valor: ");
        //num = int.Parse(Console.ReadLine());
        //rn = (num * 3 + 1) + (num * 2 - 1);

        //Console.WriteLine("O valor é: " + rn);

        //exercicio 9

        //int num, mil, cem, dez, uni;

        //Console.WriteLine("Digite um valor de quatro digitos: ");
        //num = int.Parse(Console.ReadLine());

        //mil = num / 1000;
        //cem = num / 100 - 10 * mil;
        //dez = num / 10 - 100 * mil - 10 * cem;
        //uni = num/ 1 - 1000 * mil - 100 * cem - 10 * dez;

        //Console.WriteLine(mil);
        //Console.WriteLine(cem);
        //Console.WriteLine(dez);
        //Console.WriteLine(uni);

        //double inv, d1, d2, d3, d4, total;

        //inv = 1000;

        //d1 = inv - inv * 0.034;
        //d2 = d1 + d1 * 0.028; 
        //d3 = d2 + d2 * 0.14; 
        //d4 = d3 - d3 * 0.085;

        //total = d4;

        //Console.WriteLine("O valor em reais é: R$" + total);

        //exercicio 11

        //int num, quad, cubo;

        //Console.WriteLine("Digite um numero: ");
        //num = int.Parse(Console.ReadLine());
        //quad = num * num;
        //cubo = quad * num;

        //Console.WriteLine("O valor ao quadrado é: " + quad + " o valor elevado ao cubo é: " + cubo);

        //exercicio 12

        //double alt, pi, pim;
        

        //Console.WriteLine("Digite sua altura: ");
        //alt = double.Parse(Console.ReadLine());

        //pi = (72.7 * h) - 58;
        //pim = (62.1 * h) - 44.7;

        //Console.WriteLine("O peso ideal para pessoas do sexo masculino é: " + pi + " e para pessoas do sexo feminino é: " + pim);

        //exercicio 13

        //O Git é um sistema de controle de versões distribuído, usado no desenvolvimento de software e  para registrar o histórico de edições de qualquer tipo de arquivo.
        //O GitHub é uma plataforma de hospedagem de código fonte e arquivos com controle de versão usando o Git.

        //1- Git Clone: Git clone é uma comando para baixar o código-fonte existente de um repositório remoto.
        //2- Git Branch: Usando as branches, vários desenvolvedores conseguem trabalhar em paralelo no mesmo projeto simultaneamente.
        //3- Git Checkout: Usamos git checkout, na maioria dos casos, para trocar de uma branch para outra.
        //4- Git Status: O comando git status nos dá todas as informações necessárias sobre a branch atual.
        //5- Git Add: Precisamos usar o comando git add para incluir as alterações de um ou vários arquivos em nosso próximo commit.
        //6- Git Commit: Este comando é utilizado para definir um ponto de verificação no processo de desenvolvimento.
        //7- Git Push: Git Push faz o upload dos seus commits no repositório remoto.
        //8- Git Pull: O comando git pull é usado para obter as atualizações de um repositório remoto.
        //9- Git Revert: O git revert é utilizado para desfazer as commits.
        //10- Git Merge: Este comando integra sua branch com o recurso e todos os seus commits na branch de desenvolvimento ou na branch principal.

    }
}