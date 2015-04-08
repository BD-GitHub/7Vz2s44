Imports FileHelpers

'Public Class Record


<FixedLengthRecord(FixedMode.ExactLength)> _
Public NotInheritable Class CourtFileRecord


    <FieldTrim(TrimMode.Both), _
     FieldFixedLength(20)> _
    Private mLName As String

    Public Property LName As String
        Get
            Return mLName
        End Get
        Set(value As String)
            mLName = value
        End Set
    End Property


    <FieldTrim(TrimMode.Both), _
     FieldFixedLength(14)> _
    Private mFName As String

    Public Property FName As String
        Get
            Return mFName
        End Get
        Set(value As String)
            mFName = value
        End Set
    End Property


    <FieldFixedLength(1)> _
    Private minitial As String

    Public Property initial As String
        Get
            Return minitial
        End Get
        Set(value As String)
            minitial = value
        End Set
    End Property


    <FieldTrim(TrimMode.Right), _
     FieldFixedLength(25)> _
    Private mAddress1 As String

    Public Property Address1 As String
        Get
            Return mAddress1
        End Get
        Set(value As String)
            mAddress1 = value
        End Set
    End Property


    <FieldTrim(TrimMode.Right), _
     FieldFixedLength(25)> _
    Private mAddress2 As String

    Public Property Address2 As String
        Get
            Return mAddress2
        End Get
        Set(value As String)
            mAddress2 = value
        End Set
    End Property


    <FieldTrim(TrimMode.Right), _
     FieldFixedLength(20)> _
    Private mCity As String

    Public Property City As String
        Get
            Return mCity
        End Get
        Set(value As String)
            mCity = value
        End Set
    End Property


    <FieldTrim(TrimMode.Right), _
     FieldFixedLength(2)> _
    Private mState As String

    Public Property State As String
        Get
            Return mState
        End Get
        Set(value As String)
            mState = value
        End Set
    End Property


    <FieldFixedLength(5)> _
    Private mZip As String

    Public Property Zip As String
        Get
            Return mZip
        End Get
        Set(value As String)
            mZip = value
        End Set
    End Property


    <FieldFixedLength(6)> _
    Private mZipExtended As String

    Public Property ZipExtended As String
        Get
            Return mZipExtended
        End Get
        Set(value As String)
            mZipExtended = value
        End Set
    End Property


    <FieldFixedLength(8)> _
    Private mDOB As String

    Public Property DOB As String
        Get
            Dim mDay As String
            Dim mMonth As String
            Dim mYear As String
            mYear = Right(mDOB, 2) + Left(mDOB, 2)
            mMonth = Mid(mDOB, 3, 2)
            mDay = Mid(mDOB, 5, 2)
            mDOB = String.Format("{0}/{1}/{2}", mMonth, mDay, mYear)
            Return mDOB
        End Get
        Set(value As String)
            mDOB = value
        End Set
    End Property


    <FieldFixedLength(1)> _
    Private mSex As String

    Public Property Sex As String
        Get
            Return mSex
        End Get
        Set(value As String)
            mSex = value
        End Set
    End Property


    <FieldFixedLength(25)> _
    Private mDriverLicNum As String

    Public Property DriverLicNum As String
        Get
            mDriverLicNum = Replace(mDriverLicNum, "-", "")
            Return mDriverLicNum
        End Get
        Set(value As String)
            mDriverLicNum = value
        End Set
    End Property


    <FieldFixedLength(2)> _
    Private mDriverLicSt As String

    Public Property DriverLicSt As String
        Get
            Return mDriverLicSt
        End Get
        Set(value As String)
            mDriverLicSt = value
        End Set
    End Property


    <FieldFixedLength(12)> _
    Private mCasenum As String

    Public Property Casenum As String
        Get
            Return mCasenum
        End Get
        Set(value As String)
            mCasenum = value
        End Set
    End Property


    <FieldFixedLength(2)> _
    Private mBranch As String

    Public Property Branch As String
        Get
            Return mBranch
        End Get
        Set(value As String)
            mBranch = value
        End Set
    End Property


    <FieldFixedLength(4)> _
    Private mMunicipality As String

    Public Property Municipality As String
        Get
            Return mMunicipality
        End Get
        Set(value As String)
            mMunicipality = value
        End Set
    End Property


    <FieldFixedLength(8)> _
    Private mOffenseDate As String

    Public Property OffenseDate As String
        Get
            Dim mDay As String
            Dim mMonth As String
            Dim mYear As String
            mYear = Right(mOffenseDate, 2) + Left(mOffenseDate, 2)
            mMonth = Mid(mOffenseDate, 3, 2)
            mDay = Mid(mOffenseDate, 5, 2)
            mOffenseDate = String.Format("{0}/{1}/{2}", mMonth, mDay, mYear)
            Return mOffenseDate
        End Get
        Set(value As String)
            mOffenseDate = value
        End Set
    End Property


    <FieldFixedLength(8)> _
    Private mReturnDate As String

    Public Property ReturnDate As String
        Get
            Dim mDay As String
            Dim mMonth As String
            Dim mYear As String
            mYear = Right(mReturnDate, 2) + Left(mReturnDate, 2)
            mMonth = Mid(mReturnDate, 3, 2)
            mDay = Mid(mReturnDate, 5, 2)
            mReturnDate = String.Format("{0}/{1}/{2}", mMonth, mDay, mYear)
            Return mReturnDate
        End Get
        Set(value As String)
            mReturnDate = value
        End Set
    End Property


    <FieldFixedLength(5)> _
    Private mChargeDispCode As String

    Public Property ChargeDispCode As String
        Get
            Return mChargeDispCode
        End Get
        Set(value As String)
            mChargeDispCode = value
        End Set
    End Property


    <FieldFixedLength(4)> _
    Private mSentType As String

    Public Property SentType As String
        Get
            Return mSentType
        End Get
        Set(value As String)
            mSentType = value
        End Set
    End Property


    <FieldFixedLength(2)> _
    Private mCourseLen As String

    Public Property CourseLen As String
        Get
            Return mCourseLen
        End Get
        Set(value As String)
            mCourseLen = value
        End Set
    End Property


    <FieldFixedLength(8)> _
    Private mCompletionDate As String

    Public Property CompletionDate As String
        Get
            Return mCompletionDate
        End Get
        Set(value As String)
            mCompletionDate = value
        End Set
    End Property


    <FieldFixedLength(1)> _
    Private mCompletionCode As String

    Public Property CompletionCode As String
        Get
            Return mCompletionCode
        End Get
        Set(value As String)
            mCompletionCode = value
        End Set
    End Property


    <FieldFixedLength(1)> _
    Private mTapeIndicator As String

    Public Property TapeIndicator As String
        Get
            Return mTapeIndicator
        End Get
        Set(value As String)
            mTapeIndicator = value
        End Set
    End Property


    <FieldFixedLength(4)> _
    Private mParySeqNum As String

    Public Property ParySeqNum As String
        Get
            Return mParySeqNum
        End Get
        Set(value As String)
            mParySeqNum = value
        End Set
    End Property


    <FieldFixedLength(4)> _
    Private mChargeSeqNum As String

    Public Property ChargeSeqNum As String
        Get
            Return mChargeSeqNum
        End Get
        Set(value As String)
            mChargeSeqNum = value
        End Set
    End Property


    <FieldFixedLength(4)> _
    Private mChargeDispNum As String

    Public Property ChargeDispNum As String
        Get
            Return mChargeDispNum
        End Get
        Set(value As String)
            mChargeDispNum = value
        End Set
    End Property


    <FieldFixedLength(4)> _
    Private mSentenceSeqNum As String

    Public Property SentenceSeqNum As String
        Get
            Return mSentenceSeqNum
        End Get
        Set(value As String)
            mSentenceSeqNum = value
        End Set
    End Property



End Class

