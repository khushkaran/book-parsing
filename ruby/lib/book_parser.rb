class BookParser
  attr_reader :book

  def initialize(textfile)
    @book = File.read(textfile)
  end
end