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

## Repositorio

https://github.com/Osvaldo8005/aura_game
