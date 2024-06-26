USE [DBSystemUniBizConnect]
GO
/****** Object:  Table [dbo].[EstudiantesUniversitarios]    Script Date: 20/04/2024 14:49:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstudiantesUniversitarios](
	[Codigo] [varchar](5) NULL,
	[Pais] [varchar](50) NULL,
	[Institucion] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[FechaNacimiento] [varchar](10) NULL,
	[Sexo] [char](1) NULL,
	[Email] [varchar](50) NULL,
	[Carrera] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[sp_buscar_estudiantes]    Script Date: 20/04/2024 14:49:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_buscar_estudiantes]
	@Nombre varchar (50)
as
begin
    select Codigo, Pais, Institucion, Nombre, Apellido, FechaNacimiento, Sexo, Email, Carrera
    from EstudiantesUniversitarios
    where 
		Nombre like '%' + @Nombre + '%'
end
GO
/****** Object:  StoredProcedure [dbo].[sp_listar_estudiantes]    Script Date: 20/04/2024 14:49:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_listar_estudiantes]
as
select * from EstudiantesUniversitarios order by Codigo
GO
/****** Object:  StoredProcedure [dbo].[sp_mantenimiento_estudiantes]    Script Date: 20/04/2024 14:49:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_mantenimiento_estudiantes]
    @Codigo varchar (5),
    @Pais varchar(50),
    @Institucion varchar(50),
    @Nombre varchar(50),
    @Apellido varchar(50),
    @FechaNacimiento varchar (10),
    @Sexo char,
    @Email varchar (50),
	@Carrera varchar (100),
    @Accion varchar(50) output
as
begin
    if (@Accion = '1')--Procedimiento para agregar//////////////////////////////////////////////////////////////////
    begin
        declare @Codnuevo varchar(5), @Codmax varchar(5)
        set @Codmax = (select max(Codigo) from EstudiantesUniversitarios)
        set @Codmax = isnull (@Codmax, 'A0000')
		set @Codnuevo = 'A'+RIGHT(RIGHT(@Codmax,4)+10001,4)
        insert into EstudiantesUniversitarios (Codigo, Pais, Institucion, Nombre, Apellido, FechaNacimiento, Sexo, Email, Carrera)
        values (@Codnuevo, @Pais, @Institucion, @Nombre, @Apellido, @FechaNacimiento, @Sexo, @Email, @Carrera)
        set @Accion = 'Se ha generado el código: ' + @codnuevo + ' para este usuairo.'
    end
    else if (@Accion = '2')--Procedimiento para modificar///////////////////////////////////////////////////////////
    begin
        update EstudiantesUniversitarios 
        set Pais = @Pais, 
            Institucion = @Institucion, 
            Nombre = @Nombre, 
            Apellido = @Apellido, 
            FechaNacimiento = @FechaNacimiento, 
            Sexo = @Sexo,
            Email = @Email,
			Carrera = @Carrera
        where Codigo = @Codigo
        set @Accion = 'Se ha modificado el código: ' + @Codigo + ' para este usuario.'
    end
    else if (@Accion = '3')--Procedimiento para eliminar//////////////////////////////////////////////////////////////
    begin
        delete from EstudiantesUniversitarios where Codigo = @Codigo
        set @Accion = 'Se ha borrado el código: ' + @Codigo + ' para este usuario.'
    end
end
GO
