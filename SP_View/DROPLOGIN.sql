CREATE PROC SP_RemoveLogin
  @USRNAME VARCHAR(50)
AS
BEGIN
	DECLARE @LGNAME VARCHAR(50)=(SELECT l.name FROM sys.sysusers u, sys.syslogins l WHERE u.sid = l.sid AND u.name = @USRNAME)
	IF (@LGNAME IS NOT NULL)
	BEGIN
		EXEC SP_DROPUSER @USRNAME
		EXEC SP_DROPLOGIN @LGNAME
	END
END

