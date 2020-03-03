Imports System.IO
Imports System.Net

Public Class SoapClass
    Public Request As WebRequest
    Public Response As WebResponse
    Public DataStream As Stream
    Public Reader As StreamReader
    Public SoapByte() As Byte
    Public SoapStr As String
    Public pSuccess As Boolean = True

        SoapStr = "<?xml version=""1.0"" encoding=""utf-8""?>"
        SoapStr = SoapStr & "<env:Envelope xmlns:env="http://www.w3.org/2003/05/soap-envelope" xmlns:ns1="http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd" xmlns:ns2="http://rgwspublic2/RgWsPublic2Service" xmlns:ns3="http://rgwspublic2/RgWsPublic2">"
        SoapStr = SoapStr & "<env:Header>"
        SoapStr = SoapStr & "<ns1:Security>"
        SoapStr = SoapStr & "<ns1:UsernameToken>"
        SoapStr = SoapStr & "<ns1:Username>XXXXXXXXXXXXXXXXXXXXXXXXXX</ns1:Username>"
        SoapStr = SoapStr & "<ns1:Password>YYYYYYYYYYYYYYYYYYYYYYYYYY</ns1:Password>"
        SoapStr = SoapStr & "</ns1:UsernameToken>"
        SoapStr = SoapStr & "</ns1:Security>"
        SoapStr = SoapStr & "</env:Header>"
        SoapStr = SoapStr & "<env:Body>"
        SoapStr = SoapStr & "<ns2:rgWsPublic2AfmMethod>"
        SoapStr = SoapStr & "<ns2:INPUT_REC>"
        SoapStr = SoapStr & "<ns3:afm_called_by/>"
        SoapStr = SoapStr & "<ns3:afm_called_for>069377616</ns3:afm_called_for>"
        SoapStr = SoapStr & "</ns2:INPUT_REC>"
        SoapStr = SoapStr & "</ns2:rgWsPublic2AfmMethod>"
        SoapStr = SoapStr & "</env:Body>"
        SoapStr = SoapStr & "</env:Envelope>"

        Try
            SoapByte = System.Text.Encoding.UTF8.GetBytes(SoapStr)

            Request = WebRequest.Create("https://www1.gsis.gr/wsaade/RgWsPublic2/RgWsPublic2?WSDL")
            'Request.Headers.Add("SOAPAction", "https://public-ws-stage.dpd.com/services/LoginService/V2_0/getAuth")

            Request.ContentType = "text/xml; charset=utf-8"
            Request.ContentLength = SoapByte.Length
            Request.Method = "POST"

            DataStream = Request.GetRequestStream()
            DataStream.Write(SoapByte, 0, SoapByte.Length)
            DataStream.Close()

            Response = Request.GetResponse()
            DataStream = Response.GetResponseStream()
            Reader = New StreamReader(DataStream)
            Dim SD2Request As String = Reader.ReadToEnd()

            DataStream.Close()
            Reader.Close()
            Response.Close()

        Catch ex As WebException
            MsgBox(ex.ToString())
        End Try
End Class
