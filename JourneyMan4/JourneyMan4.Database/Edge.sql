CREATE TABLE [dbo].[Edge](  
    [StartNode] [CHAR] NOT NULL, 
    [EndNode] [CHAR] NOT NULL, 
    [Weight] [INT] NOT NULL, 
	CONSTRAINT pk_Edge primary key (StartNode, EndNode),
    CONSTRAINT fk_DivCompany foreign key (StartNode) references Towns(Town),
    CONSTRAINT fk_ResCompany foreign key (EndNode) references Towns(Town)
	)