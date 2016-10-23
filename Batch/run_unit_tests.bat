echo "Running unit tests for %CD%"

IF NOT EXIST %CD%\Logs (
	mkdir %CD%\Logs
)

IF NOT EXIST %CD%\TestResults (
	mkdir %CD%\TestResults
)

"C:\Program Files\Unity\Editor\Unity.exe" -nographics -quit -batchmode -projectPath "%CD%" -logFile "%CD%\Logs\%DATE:~-4%-%DATE:~3,2%-%DATE:~0,2%_%time:~0,2%_%time:~3,2%_%time:~6,2%.log" -runEditorTests -editorTestsResultFile "%CD%\TestResults\unity_unittests_results.xml" -editorTestsFilter "Core Game Tests"

exit /b 0