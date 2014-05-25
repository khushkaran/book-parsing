class BookParser
  attr_reader :book

  def initialize(textfile)
    @book = File.read(textfile)
  end

  def split(string)
    string.gsub!(/[^\w\s]/, "")
    string.split(" ")
  end
end