### 📚 Student Profile Generator ###

Este projeto foi desenvolvido como estudo de modelagem de domínio utilizando C# e princípios de Domain-Driven Design (DDD).

Inspirado no conceito de composição de parâmetros UTM, o objetivo foi criar um modelo onde o perfil público de um estudante é gerado a partir da combinação de:

- Uma URL base

- Um Email (extraindo apenas o identificador antes do @)

🔹 Conceitos aplicados

- Value Objects (Url, Email)

- Entidade composta (Student)

- Encapsulamento de regras de negócio

- Extração de comportamento para o domínio

- Validações (Result Pattern)

- Testes unitários com xUnit

- Design orientado a responsabilidade única (SRP)


🔹 Exemplo

Entrada:
  ```sh
Url: https://instragram.com/
Email: teste@gmail.com
  ```

Saída:

  ```sh
https://instragram.com//teste
   ```
