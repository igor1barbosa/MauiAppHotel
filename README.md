# App Hotel — Hotel Mar Azul 🏨

Projeto das **Agendas 13 e 14** (Imagens e Componentes de Interface Gráfica / Orientação a Objetos e Validação de Elementos da UI) (Programação Mobile I — ETEC / Centro Paula Souza), desenvolvido em **.NET MAUI**.

## Telas
- **Cálculo da Diária** (`Views/ContratacaoHospedagem`): Stepper (adultos/crianças) ligado a Labels via `BindingContext`, Picker de suítes com `ItemDisplayBinding` e DatePickers de check-in/check-out com datas mínimas e máximas.
- **Resumo da Hospedagem** (`Views/HospedagemContratada`): recebe um objeto `Hospedagem` pelo `BindingContext` e mostra o valor total.
- **Nossas Suítes** (`Views/Suites`): lista de suítes em `CollectionView`, carregada da `List<Quarto>`. Ao tocar em uma suíte, ela volta já selecionada no Picker.
- **Sobre** (`Views/Sobre`): nome do desenvolvedor, ano de desenvolvimento, escola, curso e versão, também exibidos via `BindingContext` (`Models/InfoApp`).

## Personalizações
- Identidade visual própria (paleta azul-petróleo e dourado) e logo do hotel em SVG.
- Cartões com `Border` arredondado no lugar de `Frame`.
- Lista de suítes com valores de diária, validação de suíte selecionada e datas no padrão brasileiro (pt-BR).

## Agenda 14 — Orientação a Objetos
- Classes `Quarto` e `Hospedagem` com campos privados e propriedades `get`/`set` que validam o `value` e lançam `ArgumentException` (diária negativa, nenhuma suíte, check-out antes do check-in, etc.).
- Propriedades somente leitura calculadas (`Estadia`, `TotalHospedes`, `ValorTotal`) e o método `ValidarCapacidade()`.
- Mudanças de design: botão Avançar dourado, prévia do valor da diária, cartão de valor total com degradê e a nova tela Nossas Suítes.

## Desenvolvedor
**Igor Barbosa** — 2026 — Técnico em Desenvolvimento de Sistemas
