﻿CREATE TABLE [base].[Question] (
   [ IdQuestion]    INT NOT NULL,
    [TitluQuestion] NVARCHAR(255) NOT NULL,
    [ DescQuestion]  NVARCHAR(255) NOT NULL, 
    [TagQuestion]  NVARCHAR(255) NOT NULL,
    CONSTRAINT [PK_Question] PRIMARY KEY ([ IdQuestion]),
    
);



