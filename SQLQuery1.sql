WITH tblTempFeedback AS(SELECT *, row = ROW_NUMBER() OVER (ORDER BY ID) FROM tblShowFeedback) DELETE FROM tblTempFeedback WHERE row = 1
