# Unidad 2 - Actividad 2.2: El primer escenario

Proyecto Unity **Aura Gamer** con un menú principal en `SampleScene`: título, botones de navegación, iconos a la derecha y enlaces web a la izquierda, usando Canvas UI con anclajes verificados.

## Criterios cumplidos

1. **Tamaño de pantalla ajustable**  
   Canvas Scaler configurado para adaptar la interfaz a distintas resoluciones.

2. **Botones de navegación funcionales**  
   - **JUGAR** → carga `GameScene`  
   - **OPCIONES** → carga `OpcionesScene`  
   - **SALIR** → cierra la aplicación (`Application.Quit` / detiene Play Mode en el Editor)

3. **Puntos de anclaje correctos**  
   - Titulo: `(0.5, 0.5)`  
   - boton_Jugar: `(0.5, 0.5)`  
   - boton_Opciones: `(0.5, 0.5)`  
   - boton_Salir: `(0.5, 0.5)`  
   - IconosPanel: `(1, 0.5)` — costado derecho  
   - EnlacesPanel: `(0, 0.5)` — costado izquierdo  

## Cómo abrir el proyecto en Unity

1. Instala **Unity Hub** y la versión del editor indicada en el proyecto (Unity 6 / `6000.6.x`).
2. En Unity Hub: **Open** → selecciona la carpeta del repositorio clonado.
3. Abre la escena `Assets/Scenes/SampleScene.unity`.
4. Pulsa **Play** para probar el menú, los botones y los enlaces.


---

# Unidad 2 - Actividad 2.3: Programación de botones

Se agregaron scripts para arrastrar un sprite, controlar fuentes y fijar la navegación en la escena `SampleScene`.

## Criterios cumplidos

1. **Arrastrar un sprite**  
   Script `DragHandler.cs` asignado al objeto `Sprite_Arrastrable` (logo de AURA GAMER).  
   Usa `IBeginDragHandler`, `IDragHandler`, `IEndDragHandler` con `RectTransformUtility.ScreenPointToLocalPointInRectangle` para seguir el mouse de forma fluida.

2. **Controlar fuentes**  
   Script `FontController.cs` asignado al objeto `FontController`.  
   - Botón `Btn_AumentarFuente` (A+) → `FontController.AumentarFuente()`  
   - Botón `Btn_DisminuirFuente` (A-) → `FontController.DisminuirFuente()`  
   - Modifica el `fontSize` del objeto `Titulo` con límites mínimo 20 y máximo 150.

3. **Fijar scripts a objetos y navegación funcional**  
   - `MenuController.cs` → botones JUGAR, OPCIONES, SALIR  
   - `WebLink.cs` → 3 enlaces web (Reddit Gaming, IGN, Twitch)  
   - `DragHandler.cs` → sprite arrastrable  
   - `FontController.cs` → control de fuente  

## Cómo probar

1. Abrir `Assets/Scenes/SampleScene.unity` en Unity 6.
2. Pulsar **Play**.
3. Arrastrar el logo de AURA GAMER con el mouse.
4. Presionar **A+** para aumentar el tamaño del título.
5. Presionar **A-** para disminuirlo.
6. Probar los botones JUGAR, OPCIONES y SALIR.
7. Hacer clic en los enlaces Reddit Gaming, IGN y Twitch.


---

# Unidad 2 - Actividad 2.4: El bucle de juego y la animación

Se agregaron 3 bucles de animación a la escena `SampleScene` para dar vida al entorno del juego.

## Criterios cumplidos

1. **Tres bucles de animación (mínimo 8 frames cada uno)**
   - **Fuego de antorcha** (`Fuego_Anim`): 254 frames del spritesheet, ubicado al final de la espada del caballero rojo.
   - **Portal mágico** (`Portal_Anim`): rotación continua de 360° en 60 frames, ubicado al final de la lanza del líder azul.
   - **Carta girando** (`Carta_Anim`): rotación de 360° en 60 frames, ubicada en el cielo junto al cometa.

2. **Elementos de fondo integrados**
   - El fuego refuerza el elemento del caballero rojo (fuego).
   - El portal refuerza el poder del líder azul (magia/misticismo).
   - La carta refuerza la temática Yu-Gi-Oh del juego.

3. **Visualización integrada**
   - Todos los elementos se ven correctamente en Play Mode.
   - No tapan botones, iconos ni enlaces.

## Archivos nuevos

- `Assets/fuego/` → Spritesheet del fuego + animación `Fuego_Anim`
- `Assets/portal/` → Spritesheet del portal + animación `Portal_Anim`
- `Assets/Cartas/` → Sprite de la carta + animación `Carta_Anim`

## Cómo probar

1. Abrir `Assets/Scenes/SampleScene.unity` en Unity 6.
2. Pulsar **Play**.
3. Verificar que el fuego, el portal y la carta están animados.
4. Probar los botones JUGAR, OPCIONES y SALIR.



## Repositorio

https://github.com/Osvaldo8005/aura_game
