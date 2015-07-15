# -*-coding:utf-8-*-


from flask import Flask, render_template, redirect
from flaskext.mysql import MySQL

mysql = MySQL()
app = Flask(__name__)
app.config['MYSQL_DATABASE_USER'] = 'serverstudy'
app.config['MYSQL_DATABASE_PASSWORD'] = 'serverstudy!@#'
app.config['MYSQL_DATABASE_DB'] = 'serverstudy'
app.config['MYSQL_DATABASE_HOST'] = 'data.khuhacker.com'
app.config['MYSQL_CHARSET'] = 'utf-8'
mysql.init_app(app)

@app.route('/userlist/')
def showUser():
    cur = mysql.connect().cursor()
    cur.execute("SELECT * FROM Cs_users")
    data = cur.fetchall()
    cur.close()
    print data
    output = ""
    for user in data:
        output += "NUMBER : %s , NAME : %s , SEX : %s, DATE : %s <br>" %(user[0],user[1], user[2], user[-1])
    return output
@app.route('/adduser/<inumber>/<iname>/<isex>')

def adduser(inumber,iname,isex):
    con = mysql.connect()
    cur = con.cursor()
    cur.execute("INSERT INTO Cs_users(studentnumber,name,sex)VALUES (%s,%s,%s)", (inumber,iname,isex))
    con.commit()
    cur.close()
    return redirect('/userlist/')

if __name__ == '__main__':
    app.run()
