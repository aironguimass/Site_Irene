# Charme Salon Website API

Projeto de API para o site do salão Charme, desenvolvido em **ASP.NET Core com C#**, com frontend em Vue.js (a ser desenvolvido separadamente).  
Atualmente, o projeto cobre a estrutura de **dados e endpoints da API**, com Swagger UI para testes. Futuramente será integrado com o painel administrativo e funcionalidades de agendamento via WhatsApp.

---

## Estrutura do Site

### Parte Superior (menu horizontal)
- **Serviços** – lista de serviços principais, para não sobrecarregar  
- **Sobre** – informações básicas sobre o salão e sua história  
- **Contato** – informações de contato do salão  
- **Nossos Trabalhos** – mostrar trabalhos do salão (ex.: busca do Instagram)  
- **Agendar** – redirecionar para o WhatsApp  

### Parte Inferior (rodapé horizontal)
- WhatsApp  
- Instagram  
- Google Maps  
- Endereço  
- Número telefônico  

---

## Painel Administrativo (a ser implementado)
- Editar informações de contato  
- Editar serviços  
- Gerenciar agendamentos  
- Trocar logo e imagens do site  

---

## Banco de Dados
- SQL Server  
- Tabelas para o Painel Administrativo  

---

## Back-end
- C#  
- ASP.NET Core (API Web)  
- Controllers: `ServicesController`, `AboutController`, `ContactController`, `PortfolioController`  
- Models: `Service`, `About`, `Contact`, `Portfolio`  
- Endpoints com dados de exemplo, testados no **Swagger UI**  

---

## Front-end
- Vue.js (em desenvolvimento)  

---

## API Integrada (futura)
- Google Maps  
- WhatsApp  
- Serviço para Instagram  

---

## Como Rodar

1. Abra o projeto `Charme` no Visual Studio  
2. Pressione **F5** para iniciar a API  
3. Acesse o **Swagger UI**: `https://localhost:7017/swagger`  
4. Teste os endpoints de Services, About, Contact e Portfolio  

---

## Tecnologias
- ASP.NET Core 7  
- C#  
- SQL Server  
- Vue.js (Front-end)  
- Swagger UI para testes de API  

---
