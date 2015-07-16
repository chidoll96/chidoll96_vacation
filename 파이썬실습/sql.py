# -*-coding:utf-8-*-


from flask import Flask, render_template, redirect,request
from flaskext.mysql import MySQL

mysql = MySQL()
app = Flask(__name__)
app.config['MYSQL_DATABASE_USER'] = 'serverstudy'
app.config['MYSQL_DATABASE_PASSWORD'] = 'serverstudy!@#'
app.config['MYSQL_DATABASE_DB'] = 'serverstudy'
app.config['MYSQL_DATABASE_HOST'] = 'data.khuhacker.com'
app.config['MYSQL_CHARSET'] = 'utf-8'
mysql.init_app(app)

@app.route('/guestbook')
def guestbook():
    cur = mysql.connect().cursor()
    cur.execute("SELECT * FROM Cs_pytwit")
    return render_template("guestbook.html",datas=cur.fetchall())

@app.route('/submit', methods=['POST'])
def submit():
    if request.method == "POST":
        username = request.form['name']
        comment=request.form['comment']
        con = mysql.connect()
        cur = con.cursor()
        cur.execute("INSERT INTO Cs_pytwit(name,comment)VALUES (%s , %s)", (username,comment))
        con.commit()
        cur.close()
        con.close()
        return redirect('/guestbook')
@app.route('/delete', methods=['POST'])
def delete():
    if request.method == "POST":
        number = request.form['number']
        con = mysql.connect()
        cur = con.cursor()
        cur.execute("DELETE FROM Cs_pytwit WHERE number = %s",number)
        con.commit()
        cur.close()
        con.close()
        return redirect('/guestbook')

@app.route('/recomment', methods=['POST'])
def recomment():
    if request.method == "POST":
        number = request.form['number']
        comment = request.form['comment']
        con = mysql.connect()
        cur = con.cursor()
        cur.execute("UPDATE Cs_pytwit SET comment = %s WHERE number = %s",(comment,number))
        con.commit()
        cur.close()
        con.close()
        return redirect('/guestbook')





if __name__ == '__main__':
    app.run()
