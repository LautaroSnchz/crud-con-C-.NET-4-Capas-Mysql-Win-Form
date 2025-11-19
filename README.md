#  Sistema de Gestión de Clientes - Arquitectura en 4 Capas

<div align="center">

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)

### Sistema CRUD de clientes con arquitectura en capas, validaciones y gestión de imágenes

[Características](#-características) • [Arquitectura](#-arquitectura) • [Tecnologías](#-tecnologías) • [Instalación](#-instalación)

</div>

---

##  Descripción

Sistema de gestión de clientes desarrollado en **C# con Windows Forms**, implementando una **arquitectura de 4 capas** que separa claramente las responsabilidades del sistema. El proyecto demuestra el uso de buenas prácticas de programación orientada a objetos y patrones de arquitectura empresarial.

##  Características

### Gestión Completa de Clientes
- ✅ **Crear** nuevos registros de clientes
- ✅ **Consultar** información de clientes existentes
- ✅ **Actualizar** datos de clientes
- ✅ **Eliminar** registros de clientes

### Funcionalidades Especiales
- 📸 **Gestión de fotografías**: Carga y visualización de imágenes de clientes
- ✔️ **Validación de datos**: Sistema de validación en la capa de negocio
  - Validación de campos obligatorios (Nombre, Apellido)
  - Validación de fotografía obligatoria
  - Mensajes descriptivos al usuario
-  **Interfaz intuitiva**: Formulario Windows Forms con diseño limpio
-  **Control de ID**: Gestión automática de identificadores

## 🏛️ Arquitectura

El proyecto implementa una **arquitectura en 4 capas** siguiendo el principio de separación de responsabilidades:

```
┌─────────────────────────────────────┐
│    CAPA DE PRESENTACIÓN             │
│    (capaPresentacion)               │
│                                     │
│  • frClientes.cs (Windows Form)     │
│  • Interfaz de usuario              │
│  • Manejo de eventos                │
│  • Carga de imágenes                │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│    CAPA DE NEGOCIO                  │
│    (capaNegocio)                    │
│                                     │
│  • CNCliente.cs                     │
│  • ValidarDatos()                   │
│  • Lógica de validación             │
│  • Reglas de negocio                │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│    CAPA DE DATOS                    │
│    (capaDatos)                      │
│                                     │
│  • Conexión a MySQL                 │
│  • Operaciones CRUD                 │
│  • Gestión de consultas             │
└──────────────┬──────────────────────┘
               │
┌──────────────▼──────────────────────┐
│    CAPA DE ENTIDAD                  │
│    (capaEntidad)                    │
│                                     │
│  • CECliente.cs                     │
│  • Propiedades: Id, Nombre,         │
│    Apellido, Foto                   │
└─────────────────────────────────────┘
```

### Flujo de Operaciones

1. **Usuario** interactúa con el formulario de Windows Forms
2. **Capa de Presentación** captura los datos y eventos
3. **Capa de Negocio** valida los datos mediante `ValidarDatos()`
4. **Capa de Datos** ejecuta las operaciones en MySQL
5. **Capa de Entidad** define el modelo de datos `CECliente`

##  Tecnologías

| Tecnología | Propósito |
|------------|-----------|
| **C#** | Lenguaje de programación principal |
| **.NET Framework** | Plataforma de desarrollo |
| **Windows Forms** | Framework de interfaz gráfica |
| **MySQL** | Base de datos relacional |
| **ADO.NET** | Acceso y manipulación de datos |

##  Estructura del Proyecto

```
Udemy_CS/
│
├── capaPresentacion/           # Interfaz de usuario
│   ├── frClientes.cs          # Formulario principal
│   ├── frClientes.Designer.cs # Diseño del formulario
│   └── Program.cs             # Punto de entrada
│
├── capaNegocio/               # Lógica de negocio
│   └── CNCliente.cs           # Validaciones y reglas
│
├── capaDatos/                 # Acceso a datos
│   └── [Clases de acceso a BD]
│
└── capaEntidad/               # Modelos de datos
    └── CECliente.cs           # Entidad Cliente
```

##  Modelo de Datos

### Entidad: Cliente

| Campo | Tipo | Descripción |
|-------|------|-------------|
| **Id** | int | Identificador único |
| **Nombre** | string | Nombre del cliente (obligatorio) |
| **Apellido** | string | Apellido del cliente (obligatorio) |
| **Foto** | Image[] | Fotografía del cliente (obligatorio) |


##  Validaciones Implementadas

El sistema incluye un método `ValidarDatos()` en la capa de negocio que verifica:

- ✅ Campo **Nombre** no vacío
- ✅ Campo **Apellido** no vacío  
- ✅ **Foto** no nula
- ✅ Mensajes descriptivos mediante `MessageBox`

```csharp
public bool ValidarDatos(CECliente cliente)
{
    if(cliente.Nombre == string.Empty())
    {
        MessageBox.Show("El nombre es Obligatorio");
        return false;
    }
    
    if(cliente.Apellido == string.Empty())
    {
        MessageBox.Show("El Apellido es Obligatorio");
        return false;
    }
    
    if(cliente.Foto == null)
    {
        MessageBox.Show("La Foto es Obligatoria");
        return false;
    }
    
    return true;
}
```

##  Interfaz de Usuario

El formulario principal incluye:

- **Campos de entrada**: Id, Nombre, Apellido
- **Selector de foto**: Diálogo para cargar imágenes
- **Vista previa**: PictureBox para mostrar la foto
- **Botones de acción**: Nuevo, Eliminar, Guardar

##  Conceptos Demostrados

Este proyecto demuestra conocimientos en:

- ✅ **Arquitectura en capas** (Separation of Concerns)
- ✅ **Programación Orientada a Objetos**
- ✅ **Validación de datos** en múltiples niveles
- ✅ **Manejo de imágenes** en Windows Forms
- ✅ **Conexión a bases de datos** con ADO.NET
- ✅ **Operaciones CRUD** completas
- ✅ **Windows Forms** y manejo de eventos
- ✅ **Buenas prácticas** de nomenclatura y organización

##  Mejoras Potenciales

- [ ] Implementar búsqueda y filtros de clientes
- [ ] Agregar paginación para grandes volúmenes de datos
- [ ] Incluir exportación a Excel/PDF
- [ ] Implementar sistema de logging
- [ ] Agregar pruebas unitarias
- [ ] Migrar a .NET Core / .NET 6+
- [ ] Crear API REST para acceso multiplataforma

##  Autor

**Lautaro Sánchez**

[![GitHub](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/LautaroSnchz)

---

##  Notas

Este proyecto fue desarrollado como ejercicio práctico para demostrar la implementación de arquitectura en capas y buenas prácticas de desarrollo en C# con Windows Forms.

---



</div>
