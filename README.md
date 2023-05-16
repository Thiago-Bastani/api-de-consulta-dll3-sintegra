# Descrição
Minimal API do ASP.NET Core integrada à DLL3 do SINTEGRA para fazer a verificação de inscrições estaduais brasileiras. 

# Importante (Windows):
- Copiar DLL para a System32;
- Durante testes, rodar comando:
``` 
dotnet run --arch x86
```
(Isso é para especificar arquitetura 32 bits. Caso contrário a DLL não será interpretada corretamente)

- fazer o mesmo para publicação:
```
dotnet publish --arch x86
```

# Chamada
- http://meuserver:5114/?InscricaoEstadual=123456&UF=SP
- Substitua "meuserver", InscricaoEstadual e UF pelos valores desejados.
