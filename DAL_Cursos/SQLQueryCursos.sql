USE [CursosBBDD]
GO

SELECT [tMateria].[idMateria] AS 'Código'
      ,[tMateria].[nombre] AS 'Materia'
      ,[tMateria].[cuatrimestre] AS 'En el cuatrimestre'
	  ,[tCarrera].[nombre] AS 'Carrera'
  FROM [dbo].[tMateria], [dbo].[tCarrera]
  WHERE tMateria.idCarrera = tCarrera.idCarrera;

GO


SELECT	*
  FROM  tMateria;
GO



INSERT INTO [dbo].[tMateria]
           ([nombre]
           ,[idCarrera]
           ,[cuatrimestre])
     VALUES
           ('Base de datos I'
           ,1
           ,3)
GO

