class BookParser
  attr_accessor :book

  def initialize(textfile)
    @book = File.read(textfile)
  end

  def split(string)
    string.gsub!(/[^\w\s]/, "")
    string.split(" ")
  end

  def occurences(string)
    counts = Hash.new 0
    string.each do |word|
      counts[word.capitalize] += 1
    end
    counts
  end

  def report
    data = occurences(split(@book))
    report = "Word  |  Number of Words  |  Prime?\n"
    data.each{ |key, value|
      report << "#{key}  |  #{value}  |  #{prime?(value).to_s.capitalize}\n"
    }
    report.chomp
  end

  def prime?(integer)
    return false if integer == 1
    (2..integer).each{|number| return false if integer%number == 0 unless number == integer }
    true
  end
end