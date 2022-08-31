
using exemploaula02;

Conta conta1 ;
conta1 = new Conta();

Conta conta2 = new();

conta1.Numero = 123456;
conta2.Numero = 654321;

Conta.Limite = 1000;

Console.WriteLine($"Número da conta {conta1.Numero}");
Console.WriteLine($"Saldo da conta {conta1.Numero}: {conta1.Saldo}");

Conta.Limite = 200;

Console.WriteLine($"Saldo da conta {conta1.Numero}: {conta1.Saldo}");
Console.WriteLine($"Saldo da conta {conta2.Numero}: {conta2.Saldo}");



