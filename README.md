# 👾 Space Invaders

Proyecto desarrollado en Unity basado en el clásico arcade Space Invaders.

El objetivo del juego es eliminar todas las oleadas de enemigos antes de que alcancen la parte inferior de la pantalla o destruyan al jugador.

---

# 🎮 Descripción

Space Invaders es una recreación del famoso videojuego arcade lanzado originalmente en 1978.

En esta versión, el jugador controla una nave espacial capaz de desplazarse horizontalmente y disparar proyectiles contra las naves enemigas.

A medida que los enemigos son eliminados, la dificultad aumenta y el jugador deberá poner a prueba sus reflejos para sobrevivir.

---

# ✨ Características

- Movimiento horizontal del jugador.
- Sistema de disparos.
- Oleadas de enemigos.
- Detección de colisiones.
- Sistema de puntuación.
- Vidas del jugador.
- Pantalla de derrota.
- Reinicio de partida.
- Destrucción de enemigos.
- Gestión de niveles y dificultad.

---

# 🎮 Controles

| Acción | Tecla |
|----------|----------|
| Mover izquierda | ← |
| Mover derecha | → |
| Disparar | Espacio |

---

# 🕹️ Mecánicas principales

## Nave del jugador

El jugador controla una nave situada en la parte inferior de la pantalla.

Funciones:

- Movimiento lateral.
- Disparo de proyectiles.
- Recepción de daño.
- Gestión de vidas.

---

## Enemigos

Los enemigos aparecen organizados en formaciones.

Características:

- Movimiento grupal.
- Cambio de dirección al alcanzar los límites.
- Descenso progresivo.
- Eliminación mediante disparos.

---

## Sistema de colisiones

El juego utiliza detección de colisiones para:

- Impacto de proyectiles contra enemigos.
- Impacto de proyectiles enemigos contra el jugador.
- Destrucción de objetos.

---

## Sistema de puntuación

Cada enemigo eliminado incrementa la puntuación del jugador.

La puntuación se actualiza en tiempo real durante la partida.

---

## Condiciones de victoria

El jugador gana cuando elimina todos los enemigos de la pantalla.

---

## Condiciones de derrota

La partida termina cuando:

- El jugador pierde todas sus vidas.
- Los enemigos alcanzan la zona inferior del mapa.

---

# 🏗️ Arquitectura del proyecto

```text
Assets
│
├── Scripts
│   ├── Player
│   ├── Enemy
│   ├── Bullet
│   ├── GameManager
│   └── UI
│
├── Prefabs
│
├── Sprites
│
├── Scenes
│
└── Audio
```

---

# 🛠️ Tecnologías utilizadas

- Unity
- C#
- Visual Studio
- Unity Physics
- Unity UI System

---

# 📂 Componentes principales

## Player Controller

Gestiona:

- Movimiento.
- Disparos.
- Vidas.

## Enemy Controller

Gestiona:

- Movimiento de enemigos.
- Comportamiento de las oleadas.

## Bullet System

Gestiona:

- Creación de proyectiles.
- Movimiento.
- Colisiones.

## Game Manager

Controla:

- Estado de la partida.
- Victoria.
- Derrota.
- Reinicio.

---

# 🎯 Objetivos del proyecto

Este proyecto fue desarrollado con fines educativos para practicar conceptos fundamentales de desarrollo de videojuegos en Unity:

- Programación orientada a objetos.
- Gestión de escenas.
- Física y colisiones.
- Control de eventos.
- Arquitectura de videojuegos.
- Diseño de mecánicas arcade.

---

# 🔮 Mejoras futuras

- Power-ups.
- Diferentes tipos de enemigos.
- Sistema de niveles.
- Ranking de puntuaciones.
- Efectos de sonido avanzados.
- Animaciones mejoradas.
- Jefes finales.

---

# 👨‍💻 Autor

**Manuel Tagua**

Proyecto desarrollado utilizando Unity y C#.

---

# 📜 Licencia

Proyecto desarrollado con fines educativos y académicos.
