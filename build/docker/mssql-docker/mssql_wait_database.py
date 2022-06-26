import pyodbc
import time

while True:
    try:
        print('Trying to connect to the database ...')
        conn = pyodbc.connect('Driver={SQL Server};'
                      'Server=localhost,1433;'
                      'Database=master;'
                      'UID=sa;'
                      'PWD=x2yiJt!Fs;')
        conn.timeout=3
        cursor = conn.cursor()
        cursor.execute('SELECT count(1) FROM sys.databases')
        result = cursor.fetchone()[0]
        print('Databases count: ', result)

        if result > 0:
            print('Database accepts connections!')
            break
    except Exception:
        print('Database cannot accept connections!')
        time.sleep(1)