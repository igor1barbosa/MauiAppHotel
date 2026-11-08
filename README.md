# App Hotel — Hotel Mar Azul 🏨

Projeto da **Agenda 13 – Imagens e Componentes Diversos de Interface Gráfica** (Programação Mobile I — ETEC / Centro Paula Souza), desenvolvido em **.NET MAUI**.

## Telas
- **Cálculo da Diária** (`Views/ContratacaoHospedagem`): Stepper (adultos/crianças) ligado a Labels via `BindingContext`, Picker de suítes com `ItemDisplayBinding` e DatePickers de check-in/check-out com datas mínimas e máximas.
- **Resumo da Hospedagem** (`Views/HospedagemContratada`): recebe um objeto `Hospedagem` pelo `BindingContext` e mostra o valor total.
- **Sobre** (`Views/Sobre`): nome do desenvolvedor, ano de desenvolvimento, escola, curso e versão, também exibidos via `BindingContext` (`Models/InfoApp`).

## Personalizações
- Identidade visual própria (paleta azul-petróleo e dourado) e logo do hotel em SVG.
- Cartões com `Border` arredondado no lugar de `Frame`.
- Lista de suítes com valores de diária, validação de suíte selecionada e datas no padrão brasileiro (pt-BR).

## Desenvolvedor
**Igor Barbosa** — 2026 — Técnico em Desenvolvimento de Sistemas
