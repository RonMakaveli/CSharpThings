<h2 align="center"> 
	🚧  <em>Projeto em construção...</em>  🚧
</h2>

# Desbloqueio de Usuários no Active Directory

Este é um código em C# que permite desbloquear usuários no Active Directory. <br>
Ele utiliza a biblioteca System.DirectoryServices para se comunicar com o AD e a classe DirectoryEntry para manipular objetos no diretório.<br>

## Configuração

Antes de usar este código, você precisa substituir o valor da variável `domainPath` pela URL do seu domínio. <br>
Isso pode ser feito editando a linha seguinte:
```
string domainPath = "LDAP://DC=mydomain,DC=com"; // substitua pelo caminho do seu domínio
```
Altere ```DC=mydomain,DC=com para o nome do seu domínio.```

## Utilização

O programa solicitará que você digite o nome de usuário a ser desbloqueado. <br>
Digite o nome do usuário e pressione Enter. O programa verificará se o usuário está bloqueado e, se estiver, o desbloqueará.<br>

Se o usuário não for encontrado ou não estiver bloqueado, o programa exibirá uma mensagem apropriada.<br>
Para sair do programa, digite "sair" quando solicitado o nome de usuário.<br>

## Dependências 

Este código requer a biblioteca System.DirectoryServices, que faz parte do .NET Framework. <br>
Certifique-se de ter a versão correta do .NET Framework instalada antes de executar este programa.<br>

## Exemplo

Aqui está um exemplo de como utilizar o programa:

Digite o nome de usuário a ser desbloqueado (ou digite 'sair' para encerrar o programa): usuario1
Usuário usuario1 desbloqueado com sucesso.
Digite o nome de usuário a ser desbloqueado (ou digite 'sair' para encerrar o programa): usuario2
Usuário usuario2 não está bloqueado.
Digite o nome de usuário a ser desbloqueado (ou digite 'sair' para encerrar o programa): usuario3
Usuário usuario3 não encontrado.
Digite o nome de usuário a ser desbloqueado (ou digite 'sair' para encerrar o programa): sair

## Descrição do código

Este código é uma aplicação de console simples que utiliza a biblioteca System.DirectoryServices para desbloquear usuários no Active Directory.<br>

O programa inicia com a definição da variável domainPath, que deve ser substituída pelo caminho do seu domínio. <br>
Em seguida, o programa entra em um loop infinito que solicita que o usuário digite o nome do usuário a ser desbloqueado.<br>

O programa verifica se o usuário está bloqueado consultando o atributo "lockoutTime" do objeto do usuário no Active Directory. <br>
Se o atributo não estiver definido como zero, isso significa que o usuário está bloqueado. <br>
Nesse caso, o programa define o atributo "lockoutTime" como zero para desbloquear o usuário.<br>

O programa exibe uma mensagem de sucesso se o usuário foi desbloqueado com sucesso. <br>
Caso contrário, ele exibe uma mensagem informando que o usuário não está bloqueado ou não foi encontrado.<br>


## Features

- [x] Campo para informar usuários
- [x] Função para verificar status de usuários
- [ ] Desbloquear usuário


<h2 align="center"> 
	<em>Conclusão</em>
</h2>

Este é um código simples e eficaz que pode ser útil para administradores do Active Directory que precisam desbloquear usuários com frequência.<br> 
A documentação acima fornece uma visão geral do código e explica como configurá-lo e utilizá-lo corretamente.<br>
