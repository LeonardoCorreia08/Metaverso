Aluno: Leonardo Henrique da Silva Correia
Projeto: https://github.com/LeonardoCorreia08/Metaverso

================================================================================
  AMIA — Assistência e Manutenção Inteligente e Aumentada da ISS
  Projeto  — Metaverso | Web 3.0
================================================================================

As 3 Camadas do AMIA

Camada 1 — Inteligência Artificial (Predição) "Realizado com HBR"
IA monitorando equipamentos da ISS em tempo real, prevendo falhas antes que aconteçam. 
Sensores coletam dados e algoritmos de machine learning identificam padrões de desgaste.

Camada 2 — Realidade Aumentada (Manutenção) "Realizado com IRede"
Após a IA sinalizar o desgaste, o técnico/astronauta usa RA para executar a manutenção 
com precisão — vendo instruções sobrepostas no equipamento real, passo a passo.

Camada 3 — Metaverso/VR (Treinamento)  "Realizado com WEB3"
Antes de qualquer manutenção real, o profissional treina no ambiente virtual da ISS que 
você está construindo no Unity — simulando os procedimentos com segurança.

--------------------------------------------------------------------------------
  REQUISITOS DO SISTEMA
--------------------------------------------------------------------------------

  - Unity 6.3 LTS (6000.3.6f1) ou superior
  - Meta XR SDK (instalado e configurado)
  - XR Plugin Management configurado
  - Windows 10/11 (64-bit)
  - GPU compatível com DirectX 11 ou superior
  - Mínimo 8GB de RAM

--------------------------------------------------------------------------------
  COMO ABRIR O PROJETO
--------------------------------------------------------------------------------

  1. Clone ou baixe o repositório do GitHub
  2. Abra o Unity Hub
  3. Clique em "Add" > "Add project from disk"
  4. Selecione a pasta raiz do projeto (onde está a pasta Assets)
  5. Aguarde o Unity importar todos os assets (pode levar alguns minutos)
  6. Na janela Project, navegue até Assets > Scenes
  7. Dê duplo clique na cena "SolarSystem" para abrir

--------------------------------------------------------------------------------
  CENAS DO PROJETO
--------------------------------------------------------------------------------

  1. sistemasolar    — Cena principal com o sistema solar completo e a ISS
  2. Demo 1.0 Free  — Ambiente interior da ISS (corredor Sci-Fi modular)

--------------------------------------------------------------------------------
  CONTROLES — CENA SISTEMA SOLAR
--------------------------------------------------------------------------------

  CÂMERA:
    - Scroll do Mouse       : Zoom in/out no planeta focado
    - Botão Direito + Arrastar : Rotacionar câmera ao redor do planeta

  TROCA DE FOCO (Teclado):
    - Tecla 0  : Sistema Solar (visão geral)
    - Tecla 1  : Mercúrio
    - Tecla 2  : Vênus
    - Tecla 3  : Terra
    - Tecla 4  : Marte
    - Tecla 5  : Júpiter
    - Tecla 6  : Saturno
    - Tecla 7  : Urano
    - Tecla 8  : Netuno
    - Tecla 9  : Sol

  TROCA DE FOCO (UI):
    - Dropdown (canto inferior esquerdo) : Selecione o planeta desejado

  INTERFACE (UI — canto inferior):
    - Translação  : Liga/desliga a órbita dos planetas
    - Rotação     : Liga/desliga a rotação dos planetas
    - Órbitas     : Mostra/esconde as linhas de órbita
    - Eixos       : Mostra/esconde os eixos de rotação

--------------------------------------------------------------------------------
  CONTROLES — CENA INTERIOR DA ISS
--------------------------------------------------------------------------------

  - W / A / S / D   : Mover o personagem
  - Mouse           : Olhar ao redor (câmera em primeira pessoa)

--------------------------------------------------------------------------------
  ESTRUTURA DE PASTAS DO PROJETO
--------------------------------------------------------------------------------

  Assets/
  ├── Cobble Games/        — Modelo 3D da Estação Espacial (ISS)
  ├── Materials/           — Materiais dos planetas
  │   ├── Planets/
  │   ├── Satellites/
  │   └── Sun/
  ├── Scenes/              — Cenas do projeto
  ├── Scripts/             — Scripts C# desenvolvidos
  │   ├── Camera/          — CameraController, CameraRotation, CameraZoom
  │   ├── Celestials/      — Rotation, Traslation, CelestialBody
  │   └── GUI/             — Interface do usuário
  ├── Sci Fi Modular Pack/ — Ambiente interior da ISS
  ├── Textures/            — Texturas e skybox
  └── Imagens/             — Texturas dos planetas

--------------------------------------------------------------------------------
  INFORMAÇÕES DO PROJETO
--------------------------------------------------------------------------------

  Projeto:       AMIA — Assistência e Manutenção Inteligente e Aumentada da ISS
  Engine:        Unity 6.3 LTS (6000.3.6f1)
  Pipeline:      URP — Universal Render Pipeline (HighFidelity)
  Plataforma:    Windows, Mac & Linux Standalone / Android (Meta Quest)
  Linguagem:     C#

================================================================================
