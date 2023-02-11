# api-de-consulta-dll3-sintegra
Minimal API do ASP.NET Core integrada à DLL3 do SINTEGRA para fazer a verificação de inscrições estaduais brasileiras. 

# Importante (Windows):
- Copiar DLL para a System32;
- Durante testes, rodar comando dotnet run --arch x86 para especificar arquitetura 32 bits (fazer o mesmo para publicação)

# chamada:  http://meuserver:5114/?InscricaoEstadual=123456&UF=SP
- Substitua InscricaoEstadual e UF pelos valores desejados.